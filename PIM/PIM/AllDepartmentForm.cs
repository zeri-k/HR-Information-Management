using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace PIM
{
    public partial class AllDepartmentForm : Form
    {
        ArrayList Departmentlist = null;

        public AllDepartmentForm()
        {
            InitializeComponent();
        }
        public AllDepartmentForm(ArrayList Departmentlist)
        {
            InitializeComponent();
            this.Departmentlist = Departmentlist;
        }
        string connectionString = "provider=Microsoft.JET.OLEDB.4.0;"
                                        + "data source = "
                                        + Application.StartupPath
                                        + @"..\..\..\pim.mdb";
        private OleDbCommand myCommand = new OleDbCommand();
        private void AllDepartmentForm_Load(object sender, EventArgs e)
        {
            try
            {
                DataGridView[] dataGrids = new DataGridView[5];
                dataGrids[0] = dgvDepartmentList1;
                dataGrids[1] = dgvDepartmentList2;
                dataGrids[2] = dgvDepartmentList3;
                dataGrids[3] = dgvDepartmentList4;
                dataGrids[4] = dgvDepartmentList5;

                int j = 0;
                int k = 0;
                String[] col = new String[40];
                for (int i = 0; i < col.Length; i++)
                {
                    col[i] = "Col" + (i + 1).ToString();
                }
                OleDbConnection myConnection = new OleDbConnection(connectionString);

                foreach (Object ob in Departmentlist)
                {
                    string commandString = "select emp_num, emp_name, department, jobposition, join_day1, join_day2, join_day3, " +
                        "hl_edu, cellphone1, cellphone2, cellphone3, E_Mail from pers_info where department='" + ob.ToString() + "'";

                    myCommand.Connection = myConnection;
                    myCommand.CommandText = commandString;

                    myConnection.Open();
                    OleDbDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    int i = 0;
                    dataGrids[j].Rows.Clear();
                    while (myReader.Read())
                    {
                        dataGrids[j].Rows.Add();
                        dataGrids[j][col[k], i].Value = i + 1;
                        dataGrids[j][col[k + 1], i].Value = myReader.GetInt32(0);
                        dataGrids[j][col[k + 2], i].Value = myReader.GetString(1);
                        dataGrids[j][col[k + 3], i].Value = myReader.GetString(3);
                        dataGrids[j][col[k + 4], i].Value = myReader.GetInt32(4).ToString("0000") + "/" + myReader.GetInt32(5).ToString("00") + "/" + myReader.GetInt32(6).ToString("00");
                        dataGrids[j][col[k + 5], i].Value = myReader.GetString(7);
                        dataGrids[j][col[k + 6], i].Value = myReader.GetInt32(8).ToString("000") + "-" + myReader.GetInt32(9).ToString("0000") + "-" + myReader.GetInt32(10).ToString("0000");
                        dataGrids[j][col[k + 7], i].Value = myReader.GetString(11);
                        i++;
                    }

                    myReader.Close();
                    myConnection.Close();
                    k = k + 8;
                    j++;
                }
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void tsmPrintPreDlg_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void tsmPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            printDialog.UseEXDialog = true;

            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printDocument1.DocumentName = "전체 부서별 사원대장";
                printDocument1.Print();
            }
        }

        private void tsmManu_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.ShowDialog();
        }

        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;
        int pagenum = 1;
        int i = 0;

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Center;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;
                pagenum = 1;
                i = 0;

                // 전체 넓이
                iTotalWidth = 0;
                DataGridView[] dataGrids = new DataGridView[5];
                dataGrids[0] = dgvDepartmentList1;
                dataGrids[1] = dgvDepartmentList2;
                dataGrids[2] = dgvDepartmentList3;
                dataGrids[3] = dgvDepartmentList4;
                dataGrids[4] = dgvDepartmentList5;
                for (int i = 0; i < dataGrids.Length; i++)
                {
                    foreach (DataGridViewColumn dgvGridCol in dataGrids[i].Columns)
                    {
                        iTotalWidth += dgvGridCol.Width;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridView[] dataGrids = new DataGridView[5];
            dataGrids[0] = dgvDepartmentList1;
            dataGrids[1] = dgvDepartmentList2;
            dataGrids[2] = dgvDepartmentList3;
            dataGrids[3] = dgvDepartmentList4;
            dataGrids[4] = dgvDepartmentList5;

            Font myFont = new Font("굴림", 20, FontStyle.Bold);
            Font myFont1 = new Font("굴림", 12, FontStyle.Bold);
            Brush myBrush = new SolidBrush(Color.Black);
            try
            {
                // 왼쪽 여백
                int iLeftMargin = 80;
                // 상단 여백
                int iTopMargin = e.MarginBounds.Top;
                // 더 많은 페이지를 인쇄해야하는지 여부
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                for (int i = 0; i < dataGrids.Length; i++)
                {
                    // 셀의 넓이와 높이를 AraayList와 변수에 저장
                    if (bFirstPage)
                    {
                        foreach (DataGridViewColumn GridCol in dataGrids[i].Columns)
                        {
                            if (GridCol.Index == 0)
                            {
                                iTmpWidth = GridCol.Width - 60;
                            }
                            else if (GridCol.Index == 1 || GridCol.Index == 2)
                            {
                                iTmpWidth = GridCol.Width - 40;
                            }
                            else if (GridCol.Index >= 3 && GridCol.Index <= dataGrids[i].ColumnCount - 3)
                            {
                                iTmpWidth = GridCol.Width - 10;
                            }
                            else
                            {
                                iTmpWidth = GridCol.Width + 20;
                            }

                            // 셀의 높이 변수에 저장
                            iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                        GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                            arrColumnLefts.Add(iLeftMargin);    // 셀의 x좌표
                            arrColumnWidths.Add(iTmpWidth);     // 셀의 넓이
                            iLeftMargin += iTmpWidth;           // 다음 셀의 좌표값을 셀의 넓이로 누적 증가
                        }
                    }
                }
                DataGridViewRow GridRow = null;
                for (; i < dataGrids.Length; i++)
                {

                    // 데이터 그리드 뷰의 마지막 행까지 출력
                    while (iRow <= dataGrids[i].Rows.Count - 1)
                    {
                        GridRow = dataGrids[i].Rows[iRow];
                        // 셀 높이 조정
                        iCellHeight = GridRow.Height + 5;
                        int iCount = 0;
                        // 페이지가 여러장인지 확인
                        if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                        {
                            bNewPage = true;
                            bFirstPage = false;
                            bMorePagesToPrint = true;
                            break;
                        }
                        else
                        {
                            if (bNewPage)
                            {
                                // 머리글
                                e.Graphics.DrawString("부서별 사원대장", myFont,
                                        myBrush, e.MarginBounds.Left + 200, e.MarginBounds.Top - 80);

                                // 날짜
                                String strDate = "인쇄일: " + DateTime.Now.ToString("d");
                                strDate = strDate.Replace("-", "/");
                                e.Graphics.DrawString(strDate, myFont1,
                                        Brushes.Black,
                                        e.MarginBounds.Right - e.Graphics.MeasureString(strDate, myFont1, e.MarginBounds.Width).Width + 10,
                                        e.MarginBounds.Top - e.Graphics.MeasureString("부서별 사원대장", myFont1, e.MarginBounds.Width).Height - 16);

                                // 페이지 번호
                                String strPagenum = "페이지 번호: " + pagenum.ToString();
                                e.Graphics.DrawString(strPagenum, myFont1,
                                        Brushes.Black,
                                        e.MarginBounds.Right - e.Graphics.MeasureString(strDate, myFont1, e.MarginBounds.Width).Width + 10,
                                        e.MarginBounds.Top - e.Graphics.MeasureString("부서별 사원대장", myFont1, e.MarginBounds.Width).Height);

                                // 부서명
                                String strDepart = "부서: " + Departmentlist[i];
                                e.Graphics.DrawString(strDepart, myFont1,
                                        Brushes.Black,
                                        e.MarginBounds.Left - 20,
                                        iTopMargin - iHeaderHeight);

                                iTopMargin = e.MarginBounds.Top;
                                // 컬럼 헤더
                                foreach (DataGridViewColumn GridCol in dataGrids[i].Columns)
                                {
                                    // 헤더 색상
                                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                        new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iHeaderHeight));
                                    // 헤더 테두리
                                    e.Graphics.DrawRectangle(Pens.Black,
                                        new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iHeaderHeight));
                                    // 헤더 내용
                                    e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                        new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                        new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                    iCount++;
                                }
                                iTopMargin += iHeaderHeight;
                                bNewPage = false;

                            }
                            if (iTopMargin != e.MarginBounds.Top + iHeaderHeight && iRow == 0)
                            {
                                String strDepart = "부서: " + Departmentlist[i];
                                e.Graphics.DrawString(strDepart, myFont1,
                                        Brushes.Black,
                                        e.MarginBounds.Left - 20,
                                        iTopMargin - iHeaderHeight);

                                // 컬럼 헤더
                                foreach (DataGridViewColumn GridCol in dataGrids[i].Columns)
                                {
                                    // 헤더 색상
                                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                        new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iHeaderHeight));
                                    // 헤더 테두리
                                    e.Graphics.DrawRectangle(Pens.Black,
                                        new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iHeaderHeight));
                                    // 헤더 내용
                                    e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                        new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                        new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                        (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                    iCount++;
                                }
                                iTopMargin += iHeaderHeight;
                            }
                            iCount = 0;
                            // 데이터
                            foreach (DataGridViewCell Cel in GridRow.Cells)
                            {
                                if (Cel.Value != null)
                                {
                                    // 데이터
                                    e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                                new SolidBrush(Cel.InheritedStyle.ForeColor),
                                                new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                                (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                                }
                                // 데이터 테두리
                                e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                        iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                                iCount++;
                            }
                        }
                        iRow++;
                        iTopMargin += iCellHeight;
                    }
                    if (iRow == dataGrids[i].Rows.Count)
                    {
                        iRow = 0;
                        iTopMargin += 50;
                    }
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        break;
                    }
                }

                // 페이지가 한장 이상이라면 e.HasMorePages를 호출해 printDocument1_PrintPage()메소드 재호출
                if (bMorePagesToPrint)
                {
                    e.HasMorePages = true;
                    pagenum++;  //페이지번호 증가
                }
                else
                {
                    e.HasMorePages = false;

                    // 페이지의 끝
                    e.Graphics.DrawString("*** END ***", myFont,
                                    myBrush, e.MarginBounds.Right - 100, e.MarginBounds.Bottom);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AllDepartmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
