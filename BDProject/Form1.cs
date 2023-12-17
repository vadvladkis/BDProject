using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Помещение". При необходимости она может быть перемещена или удалена.
                this.помещениеTableAdapter.Fill(this.dataSet1.Помещение);
            }
            catch
            {
                dgvPom.Visible = false;
            }

            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Собственность". При необходимости она может быть перемещена или удалена.
                this.собственностьTableAdapter.Fill(this.dataSet1.Собственность);
            }
            catch
            {
                dgvPomLS.Visible = false;
            }

            //this.платежиTableAdapter.Fill(this.dataSet1.Платежи);

            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Платежи". При необходимости она может быть перемещена или удалена.
                this.платежиTableAdapter.Fill(this.dataSet1.Платежи);
            }
            catch
            {
                dgvPlat.Visible = false;
                tbBIK.Visible = false;
                tbRS.Visible = false;
            }

            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Начисления". При необходимости она может быть перемещена или удалена.
                this.начисленияTableAdapter.Fill(this.dataSet1.Начисления);
            }
            catch
            {
                dgvNah.Visible = false;
            }

            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Классификатор_конструктивного_элемента". При необходимости она может быть перемещена или удалена.
            this.классификатор_конструктивного_элементаTableAdapter.Fill(this.dataSet1.Классификатор_конструктивного_элемента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Работы". При необходимости она может быть перемещена или удалена.
            this.работыTableAdapter.Fill(this.dataSet1.Работы);
            
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Вид_собственности". При необходимости она может быть перемещена или удалена.
                this.вид_собственностиTableAdapter.Fill(this.dataSet1.Вид_собственности);
            }
            catch
            {
                dgvVSob.Visible = false;
            }


            try
            {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Вид_помешения". При необходимости она может быть перемещена или удалена.
            this.вид_помешенияTableAdapter.Fill(this.dataSet1.Вид_помешения);
            }
            catch
            {
                dgvVPom.Visible = false;
            }
            
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Форма_собственности". При необходимости она может быть перемещена или удалена.
                this.форма_собственностиTableAdapter.Fill(this.dataSet1.Форма_собственности);
            }
            catch
            {
                dgvFSob.Visible = false;
            }

            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Вид_документов". При необходимости она может быть перемещена или удалена.
                this.вид_документовTableAdapter.Fill(this.dataSet1.Вид_документов);
            }
            catch
            {
                dgvVDoc.Visible = false;
            }

            
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Тариф". При необходимости она может быть перемещена или удалена.
                this.тарифTableAdapter.Fill(this.dataSet1.Тариф);
            }
            catch
            {
                dgvTarif.Visible = false;
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Вид_конструктивного_элемента". При необходимости она может быть перемещена или удалена.
            this.вид_конструктивного_элементаTableAdapter.Fill(this.dataSet1.Вид_конструктивного_элемента);


            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Лицевой_счет". При необходимости она может быть перемещена или удалена.
                this.лицевой_счетTableAdapter.Fill(this.dataSet1.Лицевой_счет);
            }
            catch
            {
                dgvLS.Visible = false;
            }
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Дом". При необходимости она может быть перемещена или удалена.
            this.домTableAdapter.Fill(this.dataSet1.Дом);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Улица". При необходимости она может быть перемещена или удалена.
            this.улицаTableAdapter.Fill(this.dataSet1.Улица);

            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Собственник". При необходимости она может быть перемещена или удалена.
                //this.собственникTableAdapter.Adapter.SelectCommand.CommandText = "select * from Собственник";
                this.собственникTableAdapter.Fill(this.dataSet1.Собственник);
                //"OPEN SYMMETRIC KEY MySymmetricKey DECRYPTION BY ASYMMETRIC KEY MyAsymmetricKey WITH PASSWORD = 'qweasdzxc' "
            }
            catch
            {
                dgvSob.Visible = false;
                cbVDoc.Visible = false;
                tbKogda.Visible = false;
                cbFS.Visible = false;
                tbINN.Visible = false;
                tbKem.Visible = false;
                btnFind.Enabled = false;
            }
            

        }

        private void btnFiltr_Click(object sender, EventArgs e)
        {
            this.улицаBindingSource.Filter = "[Название улицы] LIKE '%" + tbFiltr.Text + "%'";
        }

        private void dgvTarif_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rTarif = dgvTarif.CurrentRow;
            (rTarif.DataBoundItem as DataRowView).Row["ID Тарифа"] = Guid.NewGuid();
        }

        private void dgvKonstrukt_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rKonstrukt = dgvKonstrukt.CurrentRow;
            (rKonstrukt.DataBoundItem as DataRowView).Row["ID Вида конструктивного элемента"] = Guid.NewGuid();
        }

        private void dgvPomLS_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rPomLS = dgvPomLS.CurrentRow;
            (rPomLS.DataBoundItem as DataRowView).Row["ID Собственности"] = Guid.NewGuid();
        }

        private void dgvPlat_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rPlat = dgvPlat.CurrentRow;
            (rPlat.DataBoundItem as DataRowView).Row["ID Платежа"] = Guid.NewGuid();
        }

        private void dgvNah_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rNah = dgvNah.CurrentRow;
            (rNah.DataBoundItem as DataRowView).Row["ID Начисления"] = Guid.NewGuid();
        }

        private void dgvLS_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rLS = dgvLS.CurrentRow;
            (rLS.DataBoundItem as DataRowView).Row["ID Лицевого счета"] = Guid.NewGuid();
        }

        private void dgvPom_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rPom = dgvPom.CurrentRow;
            (rPom.DataBoundItem as DataRowView).Row["ID Помещения"] = Guid.NewGuid();
        }

        private void dgvRab_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rRab = dgvRab.CurrentRow;
            (rRab.DataBoundItem as DataRowView).Row["ID Работы"] = Guid.NewGuid();
        }

        private void dgvFSob_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rFSob = dgvFSob.CurrentRow;
            (rFSob.DataBoundItem as DataRowView).Row["ID Формы собственности"] = Guid.NewGuid();
        }

        private void dgvVSob_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rVSob = dgvVSob.CurrentRow;
            (rVSob.DataBoundItem as DataRowView).Row["ID Вида собственности"] = Guid.NewGuid();
        }

        private void dgvVDoc_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rVDoc = dgvVDoc.CurrentRow;
            (rVDoc.DataBoundItem as DataRowView).Row["ID Вида документа"] = Guid.NewGuid();
        }

        private void dgvVPom_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rVPom = dgvVPom.CurrentRow;
            (rVPom.DataBoundItem as DataRowView).Row["ID Вида помещения"] = Guid.NewGuid();
        }

        private void dgvSob_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rSob = dgvSob.CurrentRow;
            (rSob.DataBoundItem as DataRowView).Row["ID Собственника"] = Guid.NewGuid();
        }

        private void dgvUl_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rUl = dgvUl.CurrentRow;
            //DataGridViewRow rDom = dataGridView1.CurrentRow;
            (rUl.DataBoundItem as DataRowView).Row["ID Улицы"] = Guid.NewGuid();
            (rUl.DataBoundItem as DataRowView).Row["Название города"] = "Санкт-Петербург";
        }

        private void tpSob_Leave(object sender, EventArgs e)
        {
            dgvSob.Select();
            if (dgvSob.Rows.Count > 0)
            {
                dgvSob.CurrentCell = dgvSob.Rows[dgvSob.Rows.Count - 1].Cells[dgvSob.CurrentCell.ColumnIndex];
            }
            this.собственникTableAdapter.Update(this.dataSet1.Собственник);
        }

        private void tpDom_Leave(object sender, EventArgs e)
        {
            this.улицаTableAdapter.Update(this.dataSet1.Улица);
            this.домTableAdapter.Update(this.dataSet1.Дом);
        }

        private void tpDomInf_Leave(object sender, EventArgs e)
        {
            this.тарифTableAdapter.Update(this.dataSet1.Тариф);
            dgvRab.Select();
            if (dgvRab.Rows.Count > 0)
            {
                dgvRab.CurrentCell = dgvRab.Rows[dgvRab.Rows.Count - 1].Cells[dgvRab.CurrentCell.ColumnIndex];
            }
            this.работыTableAdapter.Update(this.dataSet1.Работы);
            this.вид_конструктивного_элементаTableAdapter.Update(this.dataSet1.Вид_конструктивного_элемента);
            this.помещениеTableAdapter.Update(this.dataSet1.Помещение);

        }

        private void tpLS_Leave(object sender, EventArgs e)
        {
            this.лицевой_счетTableAdapter.Update(this.dataSet1.Лицевой_счет);
            this.начисленияTableAdapter.Update(this.dataSet1.Начисления);
            dgvPlat.Select();
            if (dgvPlat.Rows.Count > 0)
            {
                dgvPlat.CurrentCell = dgvPlat.Rows[dgvPlat.Rows.Count - 1].Cells[dgvPlat.CurrentCell.ColumnIndex];
            }
            this.платежиTableAdapter.Update(this.dataSet1.Платежи);
            this.собственностьTableAdapter.Update(this.dataSet1.Собственность);
        }

        private void tpSpr_Leave(object sender, EventArgs e)
        {
            this.вид_собственностиTableAdapter.Update(this.dataSet1.Вид_собственности);
            this.вид_помешенияTableAdapter.Update(this.dataSet1.Вид_помешения);
            this.вид_документовTableAdapter.Update(this.dataSet1.Вид_документов);
            this.форма_собственностиTableAdapter.Update(this.dataSet1.Форма_собственности);
            this.классификатор_конструктивного_элементаTableAdapter.Update(this.dataSet1.Классификатор_конструктивного_элемента);
        }

        private void dgvKlass_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataGridViewRow rVPom = dgvKlass.CurrentRow;
            (rVPom.DataBoundItem as DataRowView).Row["ID Классификатора конструктивного элемента"] = Guid.NewGuid();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string SQL = tbFind.Text;
            for (int i = 0; i < tbInj.Lines.Count(); i++)
            {
                string signatura = tbInj.Lines[i];
                Regex regex = new Regex(@signatura, RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(SQL);
                if (matches.Count > 0)
                {
                    MessageBox.Show("ВНИМАНИЕ!!! Обнаружена попытка взлома, ваш ПК заблокирован, отойдите от компьютера и ожидайте сотрудника СБ. Инъекция: " + signatura);
                    return;
                }
            }
            собственникTableAdapter.Adapter.SelectCommand.CommandText = "OPEN SYMMETRIC KEY MySymmetricKey DECRYPTION BY ASYMMETRIC KEY MyAsymmetricKey WITH PASSWORD = 'qweasdzxc' " +
                "SELECT [ID Собственника],[ID Формы собственности],[ID Вида документа],[Кем выдан документ],[Когда выдан документ],[ИНН]," +
                "[СНИЛС],CAST(DECRYPTBYKEY([Фамилия])as varchar(max))as[Фамилия],CAST(DECRYPTBYKEY([Имя])as varchar(max))as[Имя]," +
                "CAST(DECRYPTBYKEY([Отчество])as varchar(max))[Отчество],[Дата рождения],[Название организации] FROM [dbo].[Собственник]" +
                "where CAST(DECRYPTBYKEY([Фамилия])as varchar(max)) like '" + SQL + "'";
            собственникTableAdapter.Fill(dataSet1.Собственник);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (dgvSob.Visible==false) { return; }
            btnFind_Click(sender, e);

            собственникTableAdapter.Adapter.InsertCommand.CommandText = "OPEN SYMMETRIC KEY MySymmetricKey " +
            "DECRYPTION BY ASYMMETRIC KEY MyAsymmetricKey " +
            "WITH PASSWORD = 'qweasdzxc' " +
            "DECLARE @KeyGUID AS[uniqueidentifier] " +
            "set @KeyGUID = (select key_guid from sys.openkeys where key_name = 'MySymmetricKey') " +
            "declare @F varchar(max),@I varchar(max),@O varchar(max) set @F=ISNULL(?,'') set @I=ISNULL(?,'') set @O=ISNULL(?,'') " +
            " "+
            "INSERT INTO Собственник ([ID Собственника], [ID Формы собственности], [ID Вида документа], [Кем выдан документ], [Когда выдан документ], ИНН, СНИЛС, [Дата рождения], [Название организации]," +
            "Фамилия, Имя, Отчество)VALUES(?,?,?,?,?,?,?,?,?,ENCRYPTBYKEY(@KeyGUID,CAST(@F as varbinary)),ENCRYPTBYKEY(@KeyGUID,CAST(@I as varbinary)),ENCRYPTBYKEY(@KeyGUID,CAST(@O as varbinary)))";

            собственникTableAdapter.Adapter.UpdateCommand.CommandText = "OPEN SYMMETRIC KEY MySymmetricKey " +
            "DECRYPTION BY ASYMMETRIC KEY MyAsymmetricKey " +
            "WITH PASSWORD = 'qweasdzxc' " +
            "DECLARE @KeyGUID AS[uniqueidentifier] " +
            "set @KeyGUID = (select key_guid from sys.openkeys where key_name = 'MySymmetricKey') " +
            "declare @S uniqueidentifier, @F varchar(max),@I varchar(max),@O varchar(max) " +
            "set @S=? set @F=ISNULL(?,'') set @I=ISNULL(?,'') set @O=ISNULL(?,'') " +
            "UPDATE Собственник SET[ID Собственника] = @S, Фамилия = ENCRYPTBYKEY(@KeyGUID,CAST(@F as varbinary))," +
            "Имя = ENCRYPTBYKEY(@KeyGUID,CAST(@I as varbinary)), " +
            "Отчество = ENCRYPTBYKEY(@KeyGUID,CAST(@O as varbinary)), " +
            "[ID Формы собственности] = ?, [ID Вида документа] = ?, " +
            "[Кем выдан документ] = ?, [Когда выдан документ] = ?, ИНН = ?, СНИЛС = ?, [Дата рождения] = ?, [Название организации] = ? " +
            " WHERE([ID Собственника] = @S)";
        }

        private void dgvSob_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell CurCel = dgvSob.CurrentCell;
            if(dgvSob.Columns[CurCel.ColumnIndex].DataPropertyName == "Дата рождения") { return; }
            //MessageBox.Show(CurCel.ColumnIndex);
            //dgvSob.Columns[CurCel.ColumnIndex].DataPropertyName
            if (CurCel.Value == DBNull.Value)
            {
                //MessageBox.Show(dgvSob.Columns[CurCel.ColumnIndex].DataPropertyName== "Дата рождения");
                CurCel.Value = "";
            }

                //DataGridViewCell.Value
        }
    }
}
