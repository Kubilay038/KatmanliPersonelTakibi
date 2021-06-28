using Personel.Business.Abstract;
using Personel.Business.Concrete;
using Personel.DataAccess.Concrete.EntityFramework;
using Personel.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel.WebFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _personelService = new PersonelManager(new EfPersonelDal());
        }
        private IPersonelService _personelService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPersonel();
        }
        
        private void LoadPersonel()
        {
            dgwPersonel.DataSource = _personelService.GetAll();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearch.Text))
            {
                dgwPersonel.DataSource = _personelService.GetPersonelsByİsim(tbxSearch.Text);

            }
            else
            {
                LoadPersonel();
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _personelService.Add(new Personell
            {
                
                İsim= tbxName.Text,
                Soyİsim=tbxSurName.Text,
                Yaş=Convert.ToInt32(tbxAge.Text),
                TelefonNumarası = Convert.ToInt32(tbxNumber.Text),
            });
            MessageBox.Show("Eklendi");
            LoadPersonel();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _personelService.Update(new Personell
            {
                Id  = Convert.ToInt32(dgwPersonel.CurrentRow.Cells[0].Value),
                İsim = tbxUpdateName.Text,
                Soyİsim = tbxUpdateSurName.Text,
                Yaş = Convert.ToInt32(tbxUpdateAge.Text),
                TelefonNumarası = Convert.ToInt32(tbxUpdateNumber.Text),
            });
            MessageBox.Show("Güncellendi");
            LoadPersonel();
        }

        private void dgwPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateName.Text = dgwPersonel.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateSurName.Text = dgwPersonel.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateAge.Text = dgwPersonel.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateNumber.Text = dgwPersonel.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _personelService.Delete(new Personell { Id = Convert.ToInt32(dgwPersonel.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Silindi");
            LoadPersonel();
        }

    }
}
