using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVentaIS.Clases
{
    class Tamaño_automatico_de_datatables
    {
        public static void Multilinea(ref DataGridView List)
        {
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //List.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
            List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            List.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            List.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle styCabeceras = new DataGridViewCellStyle();
            styCabeceras.BackColor = System.Drawing.Color.FromArgb(0,120,215);
            styCabeceras.ForeColor = System.Drawing.Color.FromArgb(255,255,255);
            styCabeceras.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);//Microsoft Sans Serif, 11.25pt
            List.ColumnHeadersDefaultCellStyle = styCabeceras;
        }
    }
}
