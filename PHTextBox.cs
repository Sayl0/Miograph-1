using System;
using System.Windows.Forms;
/*
    Hint in textBox 
*/
namespace Miograph
{
    internal class PHTextBox : TextBox
    {
        System.Drawing.Color DefaultColor;
        public string PlaceHolderText { get; set; }
        public PHTextBox(string placeholdertext)
        {
            // получить цвет текста по умолчанию
            DefaultColor = this.ForeColor;
            // Добавляет обработчик события, когда элемент управления получает фокус
            this.GotFocus += (object sender, EventArgs e) =>
            {
                this.Text = String.Empty;
                this.ForeColor = DefaultColor;
            };

            // добавить обработку событий при потере фокуса
            this.LostFocus += (Object sender, EventArgs e) => {
                if (String.IsNullOrEmpty(this.Text) || this.Text == PlaceHolderText)
                {
                    this.ForeColor = System.Drawing.Color.Gray;
                    this.Text = PlaceHolderText;
                }
                else
                {
                    this.ForeColor = DefaultColor;
                }
            };



            if (!string.IsNullOrEmpty(placeholdertext))
            {
                // change style   
                this.ForeColor = System.Drawing.Color.Gray;
                // Add text
                PlaceHolderText = placeholdertext;
                this.Text = placeholdertext;
            }



        }

    }
}