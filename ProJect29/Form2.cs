using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProJect29
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string[] jame = new string[] { "", "สินเชื่ออเนกประสงค์พนักงานหน่วยงานเอกชน", "สิทเชื่อธนวัฎ 5 Plus", "กองทุนเงินให้กู้ยืมเพื่อการศึกษา" };//รับค่า string 
            comboBox1.DataSource = jame;//แสดงค่าที่รับมา ผ่านcombobox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "") {
                double a = double.Parse(textBox1.Text);//รับค่า double a
                double b = double.Parse(textBox4.Text);//รับค่า double b
                double c = double.Parse(textBox2.Text);//รับค่า double c
                c = c / 100;//ให้c=cคูณ100
                double d = a * c * b;//ให้ d= a คูณ c คูณ b
                label7.Text = "ดอกเบี้ยทั้งหมด : " + d.ToString();//ให้แสดงผลลัพธิ์ที่Label7
                b = b * 12;//ให้b = bคูณ 12
                double sum = (a + d) / b;//ให้sum=(a+d)/b
                textBox3.Text = sum.ToString();//ให้แสดงผลลัพธิ์ที่textbox3
            }
            else
            {
                MessageBox.Show("กรุณาใส่ข้อมูลให้ครบ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();//ออก
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = string.Format("- โปรแกรมจะคำนวณอัตราดอกเบี้ยคงที่เท่านั้น"+"\r\n"+"- คำนวณโดยการประมาณการเท่านั้น");//กำหนดข้อความที่จะให้แสดง
            MessageBox.Show(s);//แสดงผลลัพธิ์โชว์เป็น MessageBox
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            i();//นำ metthod มาให้งาน
            textBox1.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            i();//นำ metthod มาให้งาน
            textBox4.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            i();//นำ metthod มาให้งาน
            textBox2.Focus();
        }
        public void i()//สร้าง metthod
        {
            if (textBox1.Text != "")//เงื่อนไข
            {
                int number;//กำหนดตัวแปล
                float number2;//กำหนดตัวแปล
                if (!Int32.TryParse(textBox1.Text, out number) && !float.TryParse(textBox1.Text, out number2))//กำหนดเงื่อนไข
                {
                    MessageBox.Show("ข้อมูลของคุณต้องเป็นตัวเลขเท่านั้น", "ตรวจสอบความถูกต้องข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Warning);//กำหนดข้อความที่จะให้แสดง เป็น  MessageBox
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";//textBox1 =ช่องว่าง
            textBox2.Text = "";//textBox2 =ช่องว่าง
            textBox3.Text = "";//textBox3 =ช่องว่าง
            textBox4.Text = "";//textBox4 =ช่องว่าง
            comboBox1.Text = "";//comboBox1 =ช่องว่าง
            label7.Text = "ดอกเบี้ยทั้งหมด :"; //label7= ดอกเบี้ยทั้งหมด :
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "สินเชื่ออเนกประสงค์พนักงานหน่วยงานเอกชน")//กำหนดเงื่อนไข
            {
                textBox2.Text = "9.12";//ตรงเงื่อนไขให้แสดง
            }
            else if(comboBox1.Text == "สิทเชื่อธนวัฎ 5 Plus")//กำหนดเงื่อนไข
            {
                textBox2.Text = "16.12";//ตรงเงื่อนไขให้แสดง
            }
            else if (comboBox1.Text == "กองทุนเงินให้กู้ยืมเพื่อการศึกษา")//กำหนดเงื่อนไข
            {
                textBox2.Text = "1";//ตรงเงื่อนไขให้แสดง
            }
            else
            {

            }
        }
    }
}
