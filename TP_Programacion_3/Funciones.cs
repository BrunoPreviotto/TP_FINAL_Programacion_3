﻿using System.Windows.Forms;

namespace TP_Programacion_3
{
    class Funciones
    {
        public static void MError(Form actual, string mensaje)
        {
            MessageBox.Show(actual, mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MOK(Form actual, string mensaje)
        {
            MessageBox.Show(actual, mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
