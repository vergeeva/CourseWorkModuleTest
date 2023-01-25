using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trade_Desktop
{
    public partial class Form1 : Form
    {
        bool insert = false; //если не добавление, то обновление
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "оптоваяТорговляDataSet.Товары_View". При необходимости она может быть перемещена или удалена.
            this.товары_ViewTableAdapter.Fill(this.оптоваяТорговляDataSet.Товары_View);
            TableТовары.AutoResizeColumns();

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //добавить пустую строку, выделить в гриде
            //пользователь вводит данные и жмет сохранить
            try
            {
                insert = true;
                товарыViewBindingSource.AddNew();
                TableТовары.Rows[TableТовары.Rows.Count - 1].Selected = true;
            }
            catch (Exception)
            {
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                DataRowView dt;

                dt = (DataRowView)товарыViewBindingSource.Current;
                id = (int)dt["Код_товара"];

                //Удаление товара
                CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
                commodity.DeleteCommodity(id);
                this.товары_ViewTableAdapter.Fill(this.оптоваяТорговляDataSet.Товары_View);
                TableТовары.AutoResizeColumns();
                Result.Text = "Удаление товара прошло успешно";
            }
            catch (Exception)
            {
                Result.Text = "Невозможно удалить элемент, нарушение целостности данных";
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (insert)
                {
                    try
                    {
                        //добавление товара
                        insert = false;
                        CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
                        int temp = commodity.InsertCommodity(Convert.ToInt32(АртикулTB.Text), НаименованиеTB.Text,
                            Convert.ToDouble(ЦенаTB.Text));
                        Result.Text = "Добавление товара прошло успешно";
                    }
                    catch (Exception)
                    {
                        Result.Text = "ОШИБКА: Не все данные о товаре не заполнены верно!";
                    }
                }
                else
                {

                    //обновление данных о товаре
                    try
                    {
                        int id;
                        DataRowView dt;

                        dt = (DataRowView)товарыViewBindingSource.Current;
                        id = (int)dt["Код_товара"];
                        CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
                        commodity.UpdateCommodity(id, Convert.ToInt32(АртикулTB.Text), НаименованиеTB.Text,
                            Convert.ToDouble(ЦенаTB.Text));
                        Result.Text = "Обновление данных о товаре прошло успешно";
                    }
                    catch (Exception)
                    {
                        Result.Text = "ОШИБКА: Не все данные о товаре не заполнены!";
                    }                    
                }
                this.товары_ViewTableAdapter.Fill(this.оптоваяТорговляDataSet.Товары_View);
                TableТовары.AutoResizeColumns();
            }
            catch (Exception)
            {
                Result.Text = "Произошла ошибка обновления";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            товарыViewBindingSource.MoveNext();
        }

        private void TableТовары_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
