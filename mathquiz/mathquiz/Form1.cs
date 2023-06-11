using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathquiz
{
    public partial class Form1 : Form
    {
        // Rastgele sayılar oluşturmak için bir Rastgele nesnesi oluşturun.
        Random randomizer = new Random();


        // Bu girişler, toplama sorunu için sayıları saklayacaktır.
        int addend1;
        int addend2;


        // Bu girişler, çıkarma problemi için sayıları saklayacaktır.
        int minuend;
        int subtrahend;


        // Bu girişler, çarpma problemi için sayıları saklayacaktır.
        int multiplicand;
        int multiplier;


        // Bu int'ler bölme problemi için sayıları saklayacaktır.
        int dividend;
        int divisor;


        // Bu int, kalan süreyi takip edecektir.
        int timeLeft;

        /// <summary>
        /// Bu, tüm sorunları dolduran sınavı başlatır ve zamanlayıcıyı başlatır
        /// </summary>
        public void StartTheQuiz()
        {
            // Toplama problemini doldurun
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            LeftPluslabel.Text = addend1.ToString();
            RightPluslabel.Text = addend2.ToString();
            sum.Value = 0;


            // Çıkarma problemini doldurun.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            LeftMinuslabel.Text = minuend.ToString();
            RightMinuslabel.Text = subtrahend.ToString();
            difference.Value = 0;




            // Çarpma problemini doldurun.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            LeftMultilabel.Text = multiplicand.ToString();
            RightMultilabel.Text = multiplier.ToString();
            product.Value = 0;


            // Bölme problemini doldurunuz.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            LeftDividelabel.Text = dividend.ToString();
            RightDividelable.Text = divisor.ToString();
            quotient.Value = 0;




            // Zamanlayıcıyı başlatın.
            timeLeft = 30;
            Timelable.Text = "30 saniye";
            timer1.Start();


        }


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        /// <summary>
        /// Kullanıcının her şeyi doğru yapıp yapmadığını görmek için yanıtı kontrol edin.
        /// </summary>
        /// <returns>Yanıt doğruysa doğru, aksi takdirde yanlış.</returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // Kullanıcı cevabı doğru anladıysa zamanlayıcıyı durdurun ve bir Mesaj Kutusu gösterin.
                timer1.Stop();
                MessageBox.Show("Tüm sorulara doğru cevap verdiniz",
                                "Tebrikler :)");
                StartGameButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                Timelable.Text = timeLeft + " saniye";


            }
            else
            {
                // Kullanıcının süresi dolduysa zamanlayıcıyı durdurun,
                // bir Mesaj Kutusu gösterin ve yanıtları doldurun.
                timer1.Stop();
                Timelable.Text = "Süre doldu!";
                MessageBox.Show("Belirtilen sürede yapamadın", "Üzgünüm :(");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                StartGameButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // NumericUpDown kontrolünde tüm yanıtı seçin.
            NumericUpDown answerBox = sender as NumericUpDown;


            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }


        private void StartGameButton_Click_1(object sender, EventArgs e)
        {
            StartTheQuiz();
            StartGameButton.Enabled = false;
        }
    }
}
