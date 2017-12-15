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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//ออก
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();//ไปForm2
            f1.Show();//โชว์Form2
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string j = string.Format("- สินเชื่ออเนกประสงค์พนักงานหน่วยงานเอกชน" + "\r\n" +" ผู้มีสิทธิ์กู้ : เฉพาะพนักงานบริษัทเอกชน"+"\r\n"+" ดอกเบี้ย : ไม่เกิน 9.12 %"+"\r\n"+
                "- สิทเชื่อธนวัฎ 5 Plus" + "\r\n" + " ผู้มีสิทธิ์กู้ : ผู้มีรายได้ประจำทุกประเภท" + "\r\n" + " ดอกเบี้ย : 16.12 %") + "\r\n"+
                "- กองทุนเงินให้กู้ยืมเพื่อการศึกษา" + "\r\n" + " ผู้มีสิทธิ์กู้ : นักเรียน นักศึกษา" + "\r\n" + " ดอกเบี้ย : 1 %";////กำหนดข้อความที่จะให้แสดง
            MessageBox.Show(j);//แสดงผลลัพธิ์โชว์เป็น MessageBox
        }
    }
}
