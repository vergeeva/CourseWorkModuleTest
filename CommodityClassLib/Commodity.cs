using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace CommodityClassLib
{
    [Serializable]
    public class CommodityFormatError : Exception
    {
        public CommodityFormatError() { }
        public CommodityFormatError(string message) : base(message) { }
        public CommodityFormatError(string message, Exception inner) : base(message, inner) { }
        protected CommodityFormatError(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }



    public class Commodity
    {
        private int ID;
        private int Article;
        private string Name;
        private double Price;

        public Commodity()
        {
            ID = 0;
            Article = 12345;
            Name = "NoName";
            Price = 0;
        }

        public Commodity(int New_article, string New_name, double New_price)
        {
            Article = New_article;
            Name = New_name;
            Price = New_price;
        }

        public int CommodityID { get { return ID; } set { ID = value; } }
        public string CommodityName { get { return Name; } set { Name = value; } }
        public int CommodityArticle { get { return Article; }set { Article = value; } }
        public double CommodityPrice { get { return Price; } set { Price = value; } }

        public int InsertCommodity(int CommodityArticle, string CommodityName, double CommodityPrice)
        {
            if (CommodityArticle.ToString() == "" || CommodityArticle == 0)
            {
                throw new CommodityFormatError("Поле артикул не заполнено или равно нулю");
            }
            if (CommodityName == "")
            {
                throw new CommodityFormatError("Поле Наименование не заполнено");
            }
            if (CommodityPrice.ToString() == "" || CommodityPrice == 0)
            {
                throw new CommodityFormatError("Поле цена не заполнено или равно нулю");
            }
            try
            {
                //Добавление товара---------------------------------------------------------------------------
                SqlConnection connection = DBUtils.GetDBConnection();
                connection.Open();

                // Команда Insert.
                string sql = "Insert into Товары (Артикул_товара, Наименование_товара, Цена_товара_шт) "
                                                 + " values (@article, @name, @price) ";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                // Создать объект Parameter.
                SqlParameter articleParam = new SqlParameter("@article", SqlDbType.Int);
                articleParam.Value = CommodityArticle;
                cmd.Parameters.Add(articleParam);

                // Добавить параметр
                SqlParameter nameParam = cmd.Parameters.Add("@name", SqlDbType.VarChar);
                nameParam.Value = CommodityName;

                // Добавить параметр
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = CommodityPrice;

                // Выполнить Command
                cmd.ExecuteNonQuery();

                //Ищем Код добавленного товара
                sql = "Select MAX([Код_товара]) from Товары ";

                cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                DbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int last_id = Convert.ToInt32(reader[0]);

                connection.Close();
                connection.Dispose();
                connection = null;

                return last_id;
            }
            catch
            {
                throw new CommodityFormatError("Возникла ошибка при добавлении. Возможно неуникальный артикул");
            }
        }

        public bool DeleteCommodity(int CommodityID)
        {
            if (CommodityID.ToString() == "" || CommodityID == 0)
            {
                throw new CommodityFormatError("Поле код товара не заполнено или равно нулю");
            }
            try
            {
                //Удаление товара-----------------------------------------------------
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                string sql = "Delete from Товары where Код_товара = @Id ";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = CommodityID;

                // Выполнить Command
                cmd.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();
                conn = null;

                return true;
            }
            catch
            {
                throw new CommodityFormatError("Товар с данным кодом не найден");
            }
        }

        public bool UpdateCommodity(int CommodityID, int CommodityArticle, string CommodityName, double CommodityPrice)
        {
            if (CommodityID.ToString() == "" || CommodityID == 0)
            {
                throw new CommodityFormatError("Поле код товара не заполнено или равно нулю");
            }
            if (CommodityArticle.ToString() == "" || CommodityArticle == 0)
            {
                throw new CommodityFormatError("Поле артикул не заполнено или равно нулю");
            }
            if (CommodityName == "")
            {
                throw new CommodityFormatError("Поле Наименование не заполнено");
            }
            if (CommodityPrice.ToString() == "" || CommodityPrice == 0)
            {
                throw new CommodityFormatError("Поле цена не заполнено или равно нулю");
            }
            try
            {
                //Обновление товара--------------------------------------------------------------------
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                string sql = "Update Товары set Артикул_товара = @article, Наименование_товара = @name, " +
                    "Цена_товара_шт = @price where Код_товара = @Id";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = sql;

                // Добавить и настроить значение для параметра.
                cmd.Parameters.Add("@article", SqlDbType.Int).Value = CommodityArticle;
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = CommodityName;
                cmd.Parameters.Add("@price", SqlDbType.Float).Value = CommodityPrice;
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = CommodityID;

                // Выполнить Command
                cmd.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();
                conn = null;

                return true;
            }
            catch
            {
                throw new CommodityFormatError("Нарушение уникальности артикула: С данным артикулом уже есть товар");
            }
        }

        public Commodity GetCommodityByID(int CommodityID)
        {
            try
            {
                SqlConnection connection = CommodityClassLib.DBUtils.GetDBConnection();
                connection.Open();
                // Команда Select
                string sql = "Select * from Товары where Код_товара = " + CommodityID;

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                DbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                Commodity foundCommodity = new Commodity
                {
                    ID = Convert.ToInt32(reader[0]),
                    Article = Convert.ToInt32(reader[1]),
                    Name = reader[2].ToString(),
                    Price = Convert.ToDouble(reader[3])
                };

                connection.Close();
                connection.Dispose();

                return foundCommodity;
            }
            catch
            {
                throw new CommodityFormatError("Товар с данным кодом не найден");
            }
        }

        //Перегрузка оператора сравнения ==
        public static bool operator ==(Commodity first, Commodity second)
        {
            return first.Name == second.Name && first.Article == second.Article &&
               first.Price == second.Price && first.ID == second.ID;

        }
        //Перегрузка оператора !=, так как == просит эту функцию тоже
        public static bool operator !=(Commodity first, Commodity second)
        {
            return !(first == second);
        }
    }
}
