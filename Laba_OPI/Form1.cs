using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_OPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labaDataSet.vidah". При необходимости она может быть перемещена или удалена.
            this.vidahTableAdapter.Fill(this.labaDataSet.vidah);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labaDataSet.Sotrydn". При необходимости она может быть перемещена или удалена.
            this.sotrydnTableAdapter.Fill(this.labaDataSet.Sotrydn);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labaDataSet.Knigi". При необходимости она может быть перемещена или удалена.
            this.knigiTableAdapter.Fill(this.labaDataSet.Knigi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labaDataSet.izdatel". При необходимости она может быть перемещена или удалена.
            this.izdatelTableAdapter.Fill(this.labaDataSet.izdatel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labaDataSet.Chetateli". При необходимости она может быть перемещена или удалена.
            this.chetateliTableAdapter.Fill(this.labaDataSet.Chetateli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "labaDataSet.Avtor". При необходимости она может быть перемещена или удалена.
            this.avtorTableAdapter.Fill(this.labaDataSet.Avtor);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            vidahTableAdapter.Update(labaDataSet);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            LabaDataSet.AvtorRow row =
        labaDataSet.Avtor.NewAvtorRow();
            row.Фаимилия = textBox8.Text;
            row.Имя = textBox7.Text;
            labaDataSet.Avtor.Rows.Add(row);
            avtorTableAdapter.Update(labaDataSet.Avtor);
            labaDataSet.Avtor.AcceptChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LabaDataSet.ChetateliRow row =
        labaDataSet.Chetateli.NewChetateliRow();
            row.ФИО = TextBox1.Text;
            row.Адрес = TextBox2.Text;
            row.Телефон = Convert.ToInt32(TextBox3.Text);
            labaDataSet.Chetateli.Rows.Add(row);
            chetateliTableAdapter.Update(labaDataSet.Chetateli);
            labaDataSet.Chetateli.AcceptChanges();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LabaDataSet.izdatelRow row =
    labaDataSet.izdatel.NewizdatelRow();
            row.Название = textBox10.Text;
            row.Город = textBox11.Text;
            row.Телефон = Convert.ToInt32(textBox12.Text);
            row.Улица = textBox13.Text;
            row.Страна = textBox14.Text;
            labaDataSet.izdatel.Rows.Add(row);
            izdatelTableAdapter.Update(labaDataSet.izdatel);
            labaDataSet.izdatel.AcceptChanges();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LabaDataSet.KnigiRow row =
            labaDataSet.Knigi.NewKnigiRow();
            row.Год_издания = Convert.ToDateTime(textBox15.Text);
            row._Кол_во_страниц = Convert.ToInt32(textBox16.Text);
            row._Кол_во_экземляров = Convert.ToInt32(textBox17.Text);
            row.Название = textBox18.Text;
            row.Автор = textBox19.Text;
            row.Издательство = textBox20.Text;
            labaDataSet.Knigi.Rows.Add(row);
            knigiTableAdapter.Update(labaDataSet.Knigi);
            labaDataSet.Knigi.AcceptChanges();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            LabaDataSet.SotrydnRow row =
     labaDataSet.Sotrydn.NewSotrydnRow();
            row.ФИО = textBox21.Text;
            row.Адрес = textBox9.Text;
            row.Телефон = Convert.ToInt32(textBox6.Text);
            row.Стаж = Convert.ToInt32(textBox5.Text);
            labaDataSet.Sotrydn.Rows.Add(row);
            sotrydnTableAdapter.Update(labaDataSet.Sotrydn);
            labaDataSet.Sotrydn.AcceptChanges();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            LabaDataSet.vidahRow row =
  labaDataSet.vidah.NewvidahRow();
            row.Дата_выдачи = Convert.ToDateTime(textBox27.Text);
            row.Реальная_дата_возврата = Convert.ToDateTime(textBox26.Text);
            row.Плановая_Дата_возврата = Convert.ToDateTime(textBox25.Text);
            row.Читатель = textBox24.Text;
            row.Сотрудник = textBox23.Text;
            row.Книга = textBox22.Text;
            labaDataSet.vidah.Rows.Add(row);
            vidahTableAdapter.Update(labaDataSet.vidah);
            labaDataSet.vidah.AcceptChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            avtorTableAdapter.Update(labaDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chetateliTableAdapter.Update(labaDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            izdatelTableAdapter.Update(labaDataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            knigiTableAdapter.Update(labaDataSet);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sotrydnTableAdapter.Update(labaDataSet);
        }
    }
}
