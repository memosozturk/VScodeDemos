using System.Collections.Generic;
using System.Linq;
using dotnetmvcfilmproject.Models;

namespace dotnetmvcfilmproject.Data
{
    public class MovieRepository
    {
        private static List<Movie> _movies=null;
        static MovieRepository(){
            _movies =new List<Movie>()
            {
                new Movie(){
                    Id=1,
                    Name="Yeşil Yol",
                    ShortDescription="Yeşil yol",
                    Description= " <p>Yeşil Yol, bir hapishane görevlisi ile bir mahkumun öyküsünü anlatıyor. Paul Edgecomb'un hapishanedeki görevi, idama mahkum edilen mahkumları son yolculuklarına uğurlamaktır. Çalıştığı yıllar içerisinde yüzlerce mahkumu idam etmiştir. Bir gün John Coffey isimli korkutucu görünümlü bir adamla tanışır. Ancak Coffey'in bu ürkütücü görünümünün altında oldukça saf bir ruh yatmaktadır. Coffey, iki küçük kız çocuğunun katil davasında yargılanmaktadır. Coffey'in günden güne gün yüzüne çıkan dünya ötesi güçleri, karakteri hakkında yeni ipuçlarını anbean ortaya çıkaracaktır</p>",
                    Imageurl="1.jpg"
                    },
                new Movie(){
                    Id=2,
                    Name="Hızlı ve Öfkeli 12",
                    ShortDescription="Hızlı ve Öfkeli 12",
                    Description="<p>Hızlı ve Öfkeli serisinin spin-off filmi olan Hızlı ve Öfkeli: Hobbs ve Shaw, insanlığı tehlikeye sokan bir güce karşı birlikte hareket etmek zorunda kalan Hobbs ve Shaw’un hikayesini konu ediyor.Amerika’nın Diplomatik Güvenlik Hizmetlerinin sadık bir ajanı olan Luke Hobbs ile eski bir İngiliz askeri elit ajanı olan Deckard Shaw, yıllar boyu birbirlerini yenmeye çalışsalar da bu kez birlikte hareket etmek zorundadır. İnsanlık, büyük bir biyolojik tehdit ile karşı karşıyadır. Siber genetik ile güçlendirilmiş anarşist Brixton, insanlığın değişmesine neden olabilecek olan biyolojik virüsü ele geçirir. Dünyayı tehlikeye sokan Brixton'ı yenmek zorunda olan iri kıyım kanun adamı Hobbs ile kanunları hiçe sayan Shaw’un güçlerini birleştirip, birlikte mücadele etmekten başka şansı yoktur.</p>",
                    Imageurl="2.jpg"
                    },
                new Movie(){
                    Id=3,
                    Name="Avatar",
                    ShortDescription="Avatar",
                    Description="<p>Bir hırsızlık olayında ağabeyi ölen yarı felçli Jake Sully, Pandora adındaki uzak bir gezegende misyonunun başına geçmeye karar verir. Bu yerde Na’vi adında giderek tükenmekte olan bir halk yaşamaktadır. Jake, kendilerine özgü bir lisanları, dünya görüşleri ve yaşam biçimleri olan halkın arasına karıştığında doğa ile de bütünleşir. Askeri bir şirket, söz konusu yeri ve oradaki kaynakları mercek altına almak üzere Avatar adında bir program meydana getirmiştir. Bu program insanları kısmen insan kısmen de Na’vi haline büründürerek misyon amaçlı Pandora’ya göndermektedir. Bu sisteme gönüllü dahil olan Botanist Dr Grace Augustine ve Jake Sully için başka bir yaşam var olacaktır. Sully, Pandora’ya geçtiği anda felçli bedeni değişime uğrayarak işlevsel hale gelmektedir. Bu sırada Na’vi halkından Prenses Neytiri ile karşı karşıya gelen Jake, ansızın bir farkındalık yaşar ve bir araştırma misyonu ile gönderildiği bu gezegeni, kendi dünyalısından korumaya karar verir. Üç boyutlu, son teknoloji ürünü ve ciddi anlamda yüksek bütçeli filmin yönetmeni James Cameron’e, Titanik, Yaratıklar ve Terminator filmlerinden hayranız.</p>",
                    Imageurl="3.jpg"
                    },
                new Movie(){
                    Id=4,
                    Name="Yenilmezler",
                    ShortDescription="Yenilmezler",
                    Description="<p>Avengers Infinity Warun ardından pek çok süper kahraman küle dönüşmüştür. Doktor Strange, Gamora, Drax, Mantis, genç Örümcek Adam, Black Panther, Bucky Barnes, Groot, Scarlet Witch, Vision, Star Lord, Maria Hill, The Wasp ve Nick Fury gibi pek çok kahraman, Thanos'un Sonsuzluk Eldiveni'ni ele geçirmesi ve kendi dengesini kurması yüzünden yok olmuştur ve dünya umutsuz haldedir. Dünya üzerinde kalan Black Widow, Kaptan Amerika, Thor ve Hulk kendi yaslarını tutmaktayken, Iron ve Nebula ise kontrol edemedikleri bir uzay gemisinin içinde, uzay boşluğunda sürüklenmektedirler. Süper kahramanlar takımı için işler pek de iyi görünmemektedir. Ancak Kuantum Bölgesi'nden çıkmanın bir yolunu bularak Avengers ekibinin kalan üyelerine giden Ant-Man, yeni bir umut ışığı olacaktır. Daha önce var olduğunu bilmedikleri bölgeler, kahramanlar ve evrenlerin varlığını öğrenen ekip, Thanos'un kurduğu bu çarpık dengeyi değiştirmek ve kendilerinden alınanı geri getirmek için hayatlarının en büyük mücadelesine girişeceklerdir. Hepsi kişisel olarak önem verdikleri şeyleri kaybetmiş olan kahramanlarımız için intikam vakti gelmiştir.</p>",
                    Imageurl="4.jpg"
                    },
                new Movie(){
                    Id=5,
                    Name="Instellar",
                    ShortDescription="Instellar",
                    Description="<p>Yıldızlararası'nda, teknik bilgisi ve becerisi yüksek olan Cooper, geniş mısır tarlalarında çiftçilik yaparak geçinmektedir; amacı iki çocuğuna güvenli bir hayat sunmaktır. Onlarla yaşayan Büyükbaba Donald çocuklara göz kulak olurken, henüz 10 yaşındaki kızı Murph şaşırtıcı bir zekaya sahiptir. Geçmişte bıraktığı biliminsanı kariyerini özleyen Cooper'un karşısına bir gün beklenmedik bir teklif çıkar ve ailesinin, dahası insanlığın güvenliği için zorlu bir karar alması gerekir.Christopher Nolan'ın, Jonathan Nolan ile kaleme aldığı ve yönetmenliğini sırtladığı filmin yıldız oyunculardan oluşan oyuncu kadrosunda Matthew McConaughey, Anne Hathaway, Jessica Chastain, Matt Damon, Bill Irwin, John Lithgow ve Michael Caine gibi isimler yer alıyor. Bilimkurgunun yanı sıra dramatik öğeler de içeren filmin senaryosu Fizikçi Kip S. Thorne'nun evrendeki 'Solucan Delikleri' teorisinden ilham alıyor.</p>",
                    Imageurl="5.jpg"
                    }
            };
        }
        public static List<Movie> Movies{
            get{
                return _movies;
            }
        }
        public static void AddMovie(Movie Entity)
        {
            _movies.Add(Entity);
        }
        public static Movie GetById(int id){
            return _movies.FirstOrDefault(i=>i.Id==id);
        }
    }
}