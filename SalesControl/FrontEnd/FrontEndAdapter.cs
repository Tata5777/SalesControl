using System.Windows.Forms;

namespace SalesControl.FrontEnd {
    public class FrontEndAdapter {

        public static void WarningPopUp(string text) {
            MessageBox.Show(
                text,
                "Некорректная операция",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        public static void SuccessPopUp(string text) {
            MessageBox.Show(
                text,
                "Операция выполнена успешно",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public static void ErrorPopUp(string text) {
            MessageBox.Show(
                text,
                "Обнаружена ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
