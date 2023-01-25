using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trade_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static string CurrentStatus = "Статус";
        protected void Page_Load(object sender, EventArgs e)
        {
            Result.Text = CurrentStatus;
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //добавление товара
                CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
                commodity.InsertCommodity(Convert.ToInt32(АртикулTB.Text), НаименованиеTB.Text,
                    Convert.ToDouble(ЦенаTB.Text));
                CurrentStatus = "Добавление товара прошло успешно";
                Response.Redirect("WebForm1.aspx");
            }
            catch (Exception)
            {
                Result.Text = "ОШИБКА: Не все данные о товаре не заполнены верно!";
            }
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {                
                int SelectedIndex = GridView1.SelectedIndex;
                if (SelectedIndex < 0)
                {
                    Result.Text = "Ничего не выбрано";
                    return;
                }
                int id;
                id = Convert.ToInt32(GridView1.Rows[SelectedIndex].Cells[1].Text);
                CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
                commodity.UpdateCommodity(id, Convert.ToInt32(АртикулTB.Text), НаименованиеTB.Text,
                    Convert.ToDouble(ЦенаTB.Text));
                CurrentStatus = "Обновление данных о товаре прошло успешно";
                Response.Redirect("WebForm1.aspx");                
            }
            catch (Exception)
            {
                Result.Text = "ОШИБКА: Не все данные о товаре не заполнены!";
            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int SelectedIndex = GridView1.SelectedIndex;
                if (SelectedIndex < 0)
                {
                    Result.Text = "Ничего не выбрано";
                    return;
                }
                //Удаление товара
                int id;
                id = Convert.ToInt32(GridView1.Rows[SelectedIndex].Cells[1].Text);
                CommodityClassLib.Commodity commodity = new CommodityClassLib.Commodity();
                commodity.DeleteCommodity(id);
                CurrentStatus = "Удаление товара прошло успешно";
                Response.Redirect("WebForm1.aspx");
            }
            catch (Exception)
            {
                Result.Text = "Невозможно удалить элемент, нарушение целостности данных";
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string article, Name, price;
                int SelectedIndex = GridView1.SelectedIndex;
                article = GridView1.Rows[SelectedIndex].Cells[2].Text;
                Name = GridView1.Rows[SelectedIndex].Cells[3].Text;
                price = GridView1.Rows[SelectedIndex].Cells[4].Text;
                АртикулTB.Text = article;
                НаименованиеTB.Text = Name;
                ЦенаTB.Text = price;
            }
            catch
            {
            }
        }
    }
}