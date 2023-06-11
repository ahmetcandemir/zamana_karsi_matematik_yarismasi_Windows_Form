# WINDOWS FORM İLE ZAMANA KARŞI MATEMATİK YARIŞMASI
## İçindekiler
 1.[Projenin Amacı](#Projenin-Amacı)</br>
 2.[Projenin Videosu](#Projenin-Videosu)</br>
 3.[Projeden Görseller](#Projeden-Görseller)</br>
 4.[Projenin Yapım Aşamaları ve Kodlar](#Projenin-Yapım-Aşamaları-ve-Kodlar)</br>
</br>
## Projenin Amacı
Matematik hayatımızın her yerinde kullanmış olduğumuz ve sürekli olarak karşımıza çıkan bir derstir. Bu dersi çocuklara ve matematiğe karşı ön yargısı olanlara öğretmek çok önemlidir. Bu projemdeki asıl amacım bir öğretmen gibi bu dersi öğretmekten çok bu öğrendikleri bilgileri pekiştirebilmesi için yapmış olduğum bir projedir. Projemden biraz bahsetmek istiyorum. Projemde matematikte olan temel 4 işlemi (Toplama, Çıkarma, Çarpma, Bölme) 2 farklı sayı kullanarak bir cevap bulunmasıdır. Çocukların pratikte hız kazanmaları için 30 saniye süre ile bu işlemleri yapmaları gerekmektedir. </br>
</br>
## Projenin Videosu 
https://github.com/ahmetcandemir/zamana_karsi_matematik_yarismasi_Windows_Form/assets/103899051/22ed25eb-1b22-4594-86ef-f3623e287425
</br>
## Projeden Görseller
### Görsel 1
![ProjeGörsel1](https://github.com/ahmetcandemir/zamana_karsi_matematik_yarismasi_Windows_Form/assets/103899051/4bd5b4c7-41b7-4740-8267-00fb7e02c7ee) </br>
Yukarı da görmüş olduğunuz görsel projemin ana penceresidir. Sade ve kafa karışılığından uzak bir pencere tasarlayarak çocukların bu projeyi (kendilerince pratik yapmalarını sağlayan bu alıştırmayı) daha çok sevmesini sağlamak istememdedir. Toplama, çıkarma, çarpma ve bölme işlemlerini 2 farklı sayı ile işleme dahil ediyoruz. Start Game butonuna basarak 30 saniyelik işlem yapma süremiz başlamış oluyor. Çocukların rahat bir şekilde kullanabilmesi için fazla tuş kalabalığından uzak tasarladım.</br>
</br>
### Görsel 2 
![ProjeGörsel2](https://github.com/ahmetcandemir/zamana_karsi_matematik_yarismasi_Windows_Form/assets/103899051/d17e8312-5d8d-4e6e-8da9-d00ec9ee746f) </br>
Tüm sorulara doğru yanıtlar verildiği zaman karşımıza bu şekilde bu uyarı metni (textbox) ı çıkacaktır. Bu işlemleri doğru yapıldığına dair bir bilgi kutucuğudur. </br>
</br>
### Görsel 3
![ProjeGörsel3](https://github.com/ahmetcandemir/zamana_karsi_matematik_yarismasi_Windows_Form/assets/103899051/0cb9a18d-551c-4a9b-8651-9e4a1cf0afc9) </br>
Soruları 30 saniye içinde yapmadığınız takdirde karşımıza bu uyarı ekranı çıkacaktır. Sadece 30 saniye sürede yapmadığımız için değil aynı zamanda tüm sorulara doğru cevap verene kadar süre akmaya devam eder ve süre bittiğinde gene karşılaşacağımız bilgi kutucuğu bu şekildedir. </br>
</br>
## Projenin Yapım Aşamaları ve Kodlar
* Projemi yaparken ***Windows Form*** yazılım dilini kullandım.</br>
* Kodları yazabilmek için ***Microsoft Visual Studio*** uygulaması kullandım.</br>
</br>

### Kütüphaneler 
Öncelikle projemi yaparken kafamda tasarladığım bu pencere ekranı için bana gerekli olan data, int, çizim, yazı kutucukları, değişkenler, süre ve zaman gibi parametreleri için kullanılması gereken kütüphaneleri yazmakla işe koyuldum. </br>
</br>
***using System; </br>
using System.Collections.Generic; </br>
using System.ComponentModel; </br>
using System.Data; </br>
using System.Drawing; </br>
using System.Linq; </br>
using System.Text; </br>
using System.Threading.Tasks; </br>
using System.Windows.Forms;*** </br> 
</br>
Bu kod parçacığı, Windows Forms uygulamasının C# dilindeki başlık (header) dosyalarını içerir. İlgili namespace'leri ve temel sınıfları içe aktarmak için kullanılır. </br>
Bu using ifadeleri, ilgili namespace'lerdeki sınıfları doğrudan kullanmanıza olanak tanır ve kodunuzda daha kısa ve daha okunabilir bir sözdizimi sağlar. </br>
</br>

1. ### Random Sayılar
Projemizde olan 4 işlemi yapabilmek için sayılara ihtiyacımız var. Bu sayıları uygulamamız bize verirken rastgele vermesi gerekir. Rastgele sayıları bize vermek için aşağıdaki kod satırını yazdım. </br>
</br>
***Random randomizer = new Random();***</br>
</br>
Bu kod satırının ana mantığı; "Random" nesnesi olan "randomizer", rastgele sayılar oluşturabilmek için kullandım.</br>
</br>

### Sayıların Saklanması
Projede olan 4 temel işlei (Toplama, Çıkarma, Çarpma ve Bölme) için sayıları bir önceki maddeden aldık. Ancak bu sayıların saklanıp verilerde durması gerekir ve bu yüzden her bir işlem için ayrı değişkenler atıyarak bunu sağlamış oldum. Kodlar aşağıdaki gibidir. </br>
</br>
***//Bu girişler, toplama sorunu için sayıları saklayacaktır.</br>
int addend1;</br>
int addend2;</br>
</br>
//Bu girişler, çıkarma problemi için sayıları saklayacaktır.</br>
int minuend;</br>
int subtrahend;</br>
</br>
//Bu girişler, çarpma problemi için sayıları saklayacaktır.</br>
int multiplicand;</br>
int multiplier;</br>
</br>
//Bu int'ler bölme problemi için sayıları saklayacaktır.</br>
int dividend;</br>
int divisor;***</br>
</br>

### Kala Süreyi Takip Etme
Projemdeki oyunda süre olarak 30 saniye gibi bir kısıtlama var. Bu süre için ayrı br değişken atayıp kalan süreyi takip eden bir değer kullandım.</br>
</br>
***// Bu int, kalan süreyi takip edecektir.</br>
int timeLeft;***</br>
</br>

### Sınavı Başlatır 
Random sayıları üretmek, bu ürettiğimiz sayıların saklamak ve süre değişkeninden sonra artık tek yapmamız gerek iş sınavı başlatan bir değer olması gerekir. Sınavı başlattıktan sorna bu üretilen sayıları ilgili ola 2 boş kutucuğa yerleştirilmesi için yapmış olduğum değişkeleri ve bu değişkenlerin açıklamaları aşağıdaki kod satırı gibidir. </br>
</br>
***public void StartTheQuiz()</br>
        {</br>
        </br>
            // Toplama problemini doldurun</br>
            addend1 = randomizer.Next(51);</br>
            addend2 = randomizer.Next(51);</br>
            LeftPluslabel.Text = addend1.ToString();</br>
            RightPluslabel.Text = addend2.ToString();</br>
            sum.Value = 0;</br>
            </br>
            // Çıkarma problemini doldurun.</br>
            minuend = randomizer.Next(1, 101);</br>
            subtrahend = randomizer.Next(1, minuend);</br>
            LeftMinuslabel.Text = minuend.ToString();</br>
            RightMinuslabel.Text = subtrahend.ToString();</br>
            difference.Value = 0;</br>
            </br>
            // Çarpma problemini doldurun.</br>
            multiplicand = randomizer.Next(2, 11);</br>
            multiplier = randomizer.Next(2, 11);</br>
            LeftMultilabel.Text = multiplicand.ToString();</br>
            RightMultilabel.Text = multiplier.ToString();</br>
            product.Value = 0;</br>
            </br>
            // Bölme problemini doldurunuz.</br>
            divisor = randomizer.Next(2, 11);</br>
            int temporaryQuotient = randomizer.Next(2, 11);</br>
            dividend = divisor * temporaryQuotient;</br>
            LeftDividelabel.Text = dividend.ToString();</br>
            RightDividelable.Text = divisor.ToString();</br>
            quotient.Value = 0;</br>
            </br>
            // Zamanlayıcıyı başlatın.</br>
            timeLeft = 30;</br>
            Timelable.Text = "30 saniye";</br>
            timer1.Start();</br>
        }***</br>
        </br>
"StartTheQuiz" metodu, sınavı başlatır ve soruları doldurur. Her bir problem için rastgele sayılar oluşturur ve etiketleri günceller.
</br>

### Cevapları Kontrol Etme
Kullanıcının vermiş olduğu cevapların doğru mu yanlış olduğunu kontrol eden bir değişken ataması yaparak kullanıcıya yönelik bir bilgi aktarmak istedim. Kullanıcının cevapları doğru ise "true", eğer yanlış ise "false" gönderir. </br>
</br>
***private bool CheckTheAnswer()</br>
        {</br>
            if ((addend1 + addend2 == sum.Value)</br>
                && (minuend - subtrahend == difference.Value)</br>
                && (multiplicand * multiplier == product.Value)</br>
                && (dividend / divisor == quotient.Value))</br>
                return true;</br>
            else</br>
                return false;</br>
                </br>
        }</br>
        </br>
 
