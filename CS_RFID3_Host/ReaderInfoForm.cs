using Symbol.RFID3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_RFID3_Host
{
    public partial class ReaderInfoForm : Form
    {
        private AppForm m_AppForm;
        private bool m_IsLoaded;

        public ReaderInfoForm(AppForm appForm)
        {

            m_AppForm = appForm;
            m_IsLoaded = false;
            InitializeComponent();
        }
        private void ReaderInfoForm_Load(object sender, EventArgs e)
        {
            SystemInfo readerSystemInfo;
            readerSystemInfo = m_AppForm.m_ReaderMgmt.GetSystemInfo();
            this.SerialNumberDisplaylabel.Text = readerSystemInfo.SerialNumber;
            this.FlashAvailableDisplaylabel.Text = readerSystemInfo.FlashAvailable.ToString() + " bytes";
            this.RamAvailableDisplayLabel.Text = readerSystemInfo.RAMAvailable.ToString() + " bytes";
            this.FirmwareVersionDisplaylabel.Text = readerSystemInfo.RadioFirmwareVersion;
            this.ReaderNameDisplaylabel.Text = readerSystemInfo.ReaderName;

        }
    }
}
