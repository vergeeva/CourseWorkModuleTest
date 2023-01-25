using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System;

namespace CommodityClassLib.Tests
{
    [TestClass]
    public class LibTests
    {
        [TestMethod]
        public void TestSuccesInsertCommodity()
        {
            try
            {
                CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
                int this_id = commodity.InsertCommodity(101010, "Самый лучший товар", 1690);
                SqlConnection connection = CommodityClassLib.DBUtils.GetDBConnection();
                connection.Open();
                //Команда Select
                string sql = "Select MAX([Код_товара]) from Товары ";

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = sql;

                DbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int last_id = Convert.ToInt32(reader[0]);

                Assert.AreEqual(last_id, this_id);
                connection.Close();
                connection.Dispose();
                return;
            }
            catch (CommodityFormatError e)
            {
                Assert.AreEqual(e.Message, "Возникла ошибка при добавлении. Возможно неуникальный артикул");
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail("Неизвестное исключение [" + ex.Message + "]");
                return;
            }
            Assert.Fail("Исключение не сгенерировано");
        }

        [TestMethod]
        public void TestSuccesUpdateLastCommodity()
        {
            SqlConnection connection = CommodityClassLib.DBUtils.GetDBConnection();
            connection.Open();
            // Команда Select
            string sql = "Select MAX([Код_товара]) from Товары ";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            DbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int last_id = Convert.ToInt32(reader[0]);
            connection.Close();
            connection.Dispose();

            CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
            bool this_id = commodity.UpdateCommodity(last_id, 1111111111, "Первый набор для рисования", 1700);

            Assert.AreEqual(this_id, true);
        }

        [TestMethod]
        public void TestSuccesReadLastCommodity()
        {
            SqlConnection connection = CommodityClassLib.DBUtils.GetDBConnection();
            connection.Open();
            // Команда Select
            string sql = "Select TOP(1) Код_товара, Артикул_товара, Наименование_товара, Цена_товара_шт from Товары ";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            //Создаем объект товар
            CommodityClassLib.Commodity commodity;

            DbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            commodity = new CommodityClassLib.Commodity
            {
                CommodityID = Convert.ToInt32(reader[0]),
                CommodityArticle = Convert.ToInt32(reader[1]),
                CommodityName = reader[2].ToString(),
                CommodityPrice = Convert.ToDouble(reader[3])

            };
            connection.Close();
            connection.Dispose();

            //Создаем еще один объект товар для поиска
            CommodityClassLib.Commodity Foundcommodity = new CommodityClassLib.Commodity();
            Foundcommodity = commodity.GetCommodityByID(commodity.CommodityID); //Находим

            //Сравниваем
            Assert.AreEqual(commodity == Foundcommodity, true);
        }

        //Раз добавили, теперь будем удалять, чтобы не болтался товар
        [TestMethod]
        public void TestSuccesDeleteLastCommodity()
        {
            SqlConnection connection = CommodityClassLib.DBUtils.GetDBConnection();
            connection.Open();
            // Команда Select
            string sql = "Select MAX([Код_товара]) from Товары ";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            DbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int last_id = Convert.ToInt32(reader[0]);
            connection.Close();
            connection.Dispose();

            CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
            bool this_id = commodity.DeleteCommodity(last_id);

            Assert.AreEqual(this_id, true);
        }

        [TestMethod]
        public void TestFailedInsertCommodity_Name()
        {
            try
            {
                CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
                int this_id = commodity.InsertCommodity(999999, "", 1690);
            }
            catch (CommodityFormatError e)
            {
                Assert.AreEqual(e.Message, "Поле Наименование не заполнено");
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail("Неизвестное исключение [" + ex.Message + "]");
                return;
            }
            Assert.Fail("Исключение не сгенерировано");
        }

        [TestMethod]
        public void TestFailedInsertCommodity_Article()
        {
            try
            {
                CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
                int this_id = commodity.InsertCommodity(0, "Самый лучший товар", 1690);
            }
            catch (CommodityFormatError e)
            {
                Assert.AreEqual(e.Message, "Поле артикул не заполнено или равно нулю");
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail("Неизвестное исключение [" + ex.Message + "]");
                return;
            }
            Assert.Fail("Исключение не сгенерировано");
        }

        [TestMethod]
        public void TestFailedInsertCommodity_Price()
        {
            try
            {
                CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
                int this_id = commodity.InsertCommodity(999999, "Самый лучший товар", 0);
            }
            catch (CommodityFormatError e)
            {
                Assert.AreEqual(e.Message, "Поле цена не заполнено или равно нулю");
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail("Неизвестное исключение [" + ex.Message + "]");
                return;
            }
            Assert.Fail("Исключение не сгенерировано");
        }

        [TestMethod]
        public void TestFailedUpdateCommodity()
        {
            try
            {
                CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
                commodity.UpdateCommodity(0, 999999, "Самый лучший товар в мире!", 1700);
            }
            catch (CommodityFormatError e)
            {
                Assert.AreEqual(e.Message, "Поле код товара не заполнено или равно нулю");
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail("Неизвестное исключение [" + ex.Message + "]");
                return;
            }
            Assert.Fail("Исключение не сгенерировано");
        }

        [TestMethod]
        public void TestFailedDeleteLastCommodity()
        {
            try
            {
                CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
                commodity.DeleteCommodity(0);
            }
            catch (CommodityFormatError e)
            {
                Assert.AreEqual(e.Message, "Поле код товара не заполнено или равно нулю");
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail("Неизвестное исключение [" + ex.Message + "]");
                return;
            }
            Assert.Fail("Исключение не сгенерировано");
        }

        [TestMethod]
        public void TestFailedReadLastCommodity()
        {
            try
            {
                int last_id = 123456;
                CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
                commodity = commodity.GetCommodityByID(last_id);
                Assert.AreEqual(commodity.CommodityID, last_id);
            }
            catch (CommodityFormatError e)
            {
                Assert.AreEqual(e.Message, "Товар с данным кодом не найден");
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail("Неизвестное исключение [" + ex.Message + "]");
                return;
            }
            Assert.Fail("Исключение не сгенерировано");
        }

    }
}
