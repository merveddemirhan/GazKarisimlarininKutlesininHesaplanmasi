using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazKarisimlarininKutlesininHesaplanmasi
{
    public partial class Form1 : Form
        
    {
        decimal _ilkElementinAgirligi;
        int _ilkElementinMolSayisi;
        int _ilkElementinHacimOrani;
        bool _yeniElementEklenecekMi;
        public Form1()
        {
            InitializeComponent();
        }
        ElementsDal _elementsDal = new ElementsDal();
        private void Form1_Load(object sender, EventArgs e)
        {
           dgwElement.DataSource= _elementsDal.GetAll();
        }

        

        private void ListElementByElementName(string key)
        {
            using (ElementsContext context = new ElementsContext())
            {
                dgwElement.DataSource = context.Elements.Where(p=> p.ElementAdi.ToLower().Contains(key.ToLower())).ToList();
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;

            if(string.IsNullOrEmpty(key))
            {
                ElementsDal _elementsDal = new ElementsDal();
                dgwElement.DataSource = _elementsDal.GetAll(); ;
            }
            else
            {
                ListElementByElementName(tbxSearch.Text);

            }
            
        }

        

       
        private void dgwElement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxElementNo.Text= dgwElement.CurrentRow.Cells[1].Value.ToString();
            tbxElementSembolu.Text = dgwElement.CurrentRow.Cells[2].Value.ToString();
            tbxElementAdi.Text = dgwElement.CurrentRow.Cells[3].Value.ToString();
            tbxElementAtomAgirligi.Text = dgwElement.CurrentRow.Cells[4].Value.ToString();

        }

        private void tbxElementNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           _ilkElementinAgirligi= Convert.ToDecimal(tbxElementAtomAgirligi.Text);
            _ilkElementinMolSayisi = Convert.ToInt32(tbxMolSayısı.Text);
            _ilkElementinHacimOrani= Convert.ToInt32(tbxHacim.Text);
            _yeniElementEklenecekMi = true;
            if (_yeniElementEklenecekMi)
            {
                tbxElementSembolu.Text = "";
                tbxElementNo.Text = "";
                tbxElementAdi.Text = "";
                tbxElementAtomAgirligi.Text ="" ;
                tbxMolSayısı.Text = "";
                tbxHacim.Text = "";
                _yeniElementEklenecekMi = false;



            }

        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            decimal ikinciElementinAgirligi = Convert.ToDecimal(tbxElementAtomAgirligi.Text);
            int _ikinciElementinMolSayisi = Convert.ToInt32(tbxMolSayısı.Text);
            int _ikinciElementinHacimOrani = Convert.ToInt32(tbxHacim.Text);
            decimal ortamHacim = Convert.ToDecimal(tbxortamHacim.Text);

            decimal toplamGazinKMolKutlesi;
            decimal toplamGazAgirligi;
     
            decimal normalAtmosferSartlarındaMolarVolume;
            decimal birimHacimGazAgirligi;



            normalAtmosferSartlarındaMolarVolume = 22.414M;

            decimal ilkMolekulunAgirligi;
            decimal ikinciMolekulunAgirligi;
            ilkMolekulunAgirligi = _ilkElementinAgirligi *_ilkElementinHacimOrani / 100 * _ilkElementinMolSayisi;
            ikinciMolekulunAgirligi = _ilkElementinAgirligi * _ikinciElementinHacimOrani / 100 * _ikinciElementinMolSayisi;
            toplamGazinKMolKutlesi = ilkMolekulunAgirligi + ikinciMolekulunAgirligi;
            birimHacimGazAgirligi = toplamGazinKMolKutlesi / normalAtmosferSartlarındaMolarVolume;
            toplamGazAgirligi = ortamHacim * birimHacimGazAgirligi;
            toplamGazAgirligi= Math.Round(toplamGazAgirligi,2);
            lblCıktı.Text = Convert.ToString(toplamGazAgirligi);
            
            



           

           
            
            






            
            

        }
        

        private void gbxCıktı_Enter(object sender, EventArgs e)
        {

        }

        private void tbxYogunluk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
