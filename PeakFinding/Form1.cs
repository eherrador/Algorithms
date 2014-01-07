using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeakFinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPeakFinding1D_Click(object sender, EventArgs e)
        {
            int peak;

            if (rbtnScanAllArray.Checked == true)
            {
                lstOutput.Items.Add("Scan All Array Algorithm");
                PeakFinder pf = new PeakFinder();
                byte[] A = pf.InitArray4PeakFinding(Convert.ToInt32(txtArrayLength.Text));

                string sA = String.Empty;
                foreach (byte byteValue in A)
                    sA = sA + byteValue.ToString() + " ";
                lstOutput.Items.Add(sA);

                peak = pf.PeakFinding1DScanAllArray(A);
            }
            else //rbtnDivideAndConquer == true
            {
                lstOutput.Items.Add("Divide And Conquer Algorithm");
                PeakFinder pf = new PeakFinder();
                byte[] A = pf.InitArray4PeakFinding(Convert.ToInt32(txtArrayLength.Text));

                string sA = String.Empty;
                foreach (byte byteValue in A)
                    sA = sA + byteValue.ToString() + " ";
                lstOutput.Items.Add(sA);

                peak = pf.PeakFinding1DDivideAndConquer(A);
            }

            if (peak == 0)
                lstOutput.Items.Add("No peak founded");
            else
                lstOutput.Items.Add("The peak founded is: " + peak.ToString());

            lstOutput.Items.Add("\n");
        }

        private void btnPeakFinding2D_Click(object sender, EventArgs e)
        {
            int peak;
            int matrixDimension = Convert.ToInt32(txtMatrixDimension.Text);

            if (rbtnScanAllMatrix.Checked == true)
            {
                lstOutput.Items.Add("Scan matrix from L to R and T to B");
                PeakFinder pf = new PeakFinder();
                int[,] M = pf.InitMatrix4PeakFinding(matrixDimension);

                string sM = String.Empty;
                for (int i = 0; i < matrixDimension; i++)
                {
                    sM = String.Empty;
                    for (int j = 0; j < matrixDimension; j++)
                    {
                        sM = sM + (M[i, j]).ToString() + "\t";
                    }
                    lstOutput.Items.Add(sM);
                }
                lstOutput.Items.Add("\n");

                peak = pf.PeakFinding2DScanMatrixRTB(M, matrixDimension);

                lstOutput.Items.Add("The peak founded is: " + peak.ToString());
                lstOutput.Items.Add("\n");
            }
        }
    }
}
