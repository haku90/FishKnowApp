using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using FishKnow1v.Model;
using FishKnow1v.ViewModel;
using FishKnow1v.View;
namespace FishKnow1v.ViewModel
{
    public class ViewModelListEncy:ViewModelBase
    {
        static int numOfObject = 1;
        public ObservableCollection<Fish> ListFish { get; set; }
        public ViewModelListEncy()
        {
            ListFish = new ObservableCollection<Fish>();
            ListFish.Add(new Fish() 
            {
                Id=numOfObject++,
                Name = "Amur",
                Image = new Uri("/img/amur.jpg",UriKind.Relative),
                Feeding = "",
                Morpho = "amury ryby swoim wydłużonym, wrzecionowatym, bocznie spłaszczonym ciałem przypominają klenia. Linia boczna przebiega wyraźnie lekkim łukiem od płetwy ogonowej do górnej krawędzi wieczka skrzelowego.", 
                Origin = "amur był w Polsce introdukowany od połowy lat 60 w jeziorach konińskich oraz jeziorze Dgał Wielki na Pojezierzu Mazurskim, skąd przedostał się również do innych zbiorników wodnych. W późniejszym czasie amur został zasiedlony także w rzekach." });
            ListFish.Add(new Fish() 
            {
                Id = numOfObject++, 
              Name = "Boleń",
              Feeding = "",
              Morpho = "boleń w naszych wodach to najbardziej drapieżny, obok klenia, przedstawiciel rodziny karpiowatych. Już sylwetka boleń znamionuje dobrego pływaka, a płetwy dodatkowo to potwierdzają - są długie i dobrze rozwinięte. Szczególnie ogonowa jest duża, jak na typowego drapieżnika przystało. Boleń ma sporą głowę, z charakterystyczną paszczą o dolnej szczęce nieco dłuższej od górnej, a przy tym lekko hakowato podgiętej, co nadaje mu wyraz zadziornego zabijaki.",
              Origin = "boleń występuje w rzekach wielko nizinnych, rzekach średnio nizinnych.",
              Image=new Uri("/img/bolen.jpg",UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Brzana",
                Feeding = "",
                Morpho = " brzana, w przeciwieństwie do wielu karpiowatych, ma wydłużone, wrzecionowate i niewygrzbiecione ciało. Otwór gębowy poziomy, z dwoma parami wąsików na górnej wardze. Oczy kierują się nieco ku górze. Ubarwienie ryby brzana jest dosyć urozmaicone - grzbiet jest ciemniejszy od boków - oliwkowozielony lub ciemnoszary, natomiast brzuch ciemnokremowy. Płetwy grzbietowa i ogonowa są z kolei szare z ciemniejszym obrzeżeniem, natomiast pozostałe płetwy przykuwają uwagę wyraźną czerwienią. ",
                Origin = "brzana występuje w rzekach średnio nizinnych, rzekach wielko nizinnych.",
                Image=new Uri("/img/brzana.jpg",UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Dorsz",
                Feeding = "",
                Morpho = "dorsze ryby posiadają wydłużone, opływowe ciało. Głowa jest długa i masywna z szerokim pyskiem i górną szczęką wysuniętą do przodu. Na podbródku znajduje się pojedynczy, dobrze rozwinięty wąs. Płetwa ogonowa, która opiera się na symetrycznym szkielecie, jest pionowo ścięta lub lekko wklęsła. Ubarwienie dorsza jest uzależnione od podgatunku i barw przeważających w ich miejscach występowania. Grzbiet przybiera barwy od brązowego do zielonkawego lub szarooliwkowego, boki są nieco jaśniejsze, a brzuch biały. Grzbiet, wierzch głowy i boki są dodatkowo usiane licznymi, ciemnymi plamkami.",
                Origin = "dorsz jest gatunkiem wędrownym, którego można spotkać w północnej części Oceanu Atlantyckiego, od północnej Finlandii do północnej Karoliny, na wschodzie od Spitsbergenu do Zatoki Biskajskiej. W północnej Europie tereny dorsza to m.in. Morze Bałtyckie. ",
                Image=new Uri("/img/dorsz.jpg",UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Jaź",
                Feeding = "",
                Morpho = "jaź posiada wydłużone i spłaszczone bocznie ciało, linia boczna jest lekko wygięta ku dołowi, płetwa ogonowa głęboko wcięta, głowa mała z wysuwaną paszczą skierowaną ukośnie ku górze. Grzbiet ma kolor szarozielony do szaroczarnego. Boki są jaśniejsze o intensywnym srebrzystym połysku, a brzuch białawy. Płetwy grzbietowa i odbytowa mają niebieskawoszary odcień, natomiast pozostałe płetwy są czerwonawe. ",
                Origin = "rzeki średnie nizinne, rzeki wielkie nizinne.",
                Image = new Uri("/img/jaz.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Karaś",
                Feeding = "",
                Morpho = "karaś to gatunek bardzo popularny w naszych wodach. Występuje w dwóch odmianach - rodzimej zwanej też pospolitą oraz srebrnej zwanej czasem japońską. Ciało karasia jest silnie wygrzbiecone, krępe i bocznie ścieśnione. Karaś ma ubarwienie brunatnozłociste z zielonkawym połyskiem, brzuch żółtawy lub biały. Płetwy piersiowe i brzuszne przy nasadzie są lekko zaczerwienione. Na trzonie ogona znajduje się charakterystyczna, ciemna plama. ",
                Origin = "jeziora, zb. zaporowe, stawy i wyrobiska, rzeki średnie nizinne, rzeki wielkie nizinne.",
                Image = new Uri("/img/karas.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Karp",
                Feeding = "",
                Morpho = "karpie ryby posiadają wydłużone ciało, bardzo lekko bocznie ścieśnione, linia boczna jest słabo zaznaczona; głowa duża z wysuwaną paszczą wyposażona w cztery małe, krótkie wąsiki. Karp przybiera ciemnobrunatne i żółtobrunatne barwy w zależności od warunków środowiskowych. Otwór gębowy z dwoma małymi wąsikami przy górnej wardze oraz dwoma mniejszymi w kącikach warg. ",
                Origin = "w naturalnych warunkach karp przebywa w wodach stojących lub wolno płynących. Sprawdzonymi siedliskami karpia są stawy, jeziora nizinne, zbiorniki zaporowe, stawy i wyrobiska. ",
                Image = new Uri("/img/karp.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Kleń",
                Feeding = "",
                Morpho = "kleń to jedna z najczęściej poławianych ryb w polskich wodach. Kleń ma ciało wydłużone i walcowate, lekko spłaszczone bocznie. Łuski są duże, z szarą lub czarną obwódką i tworzą na całym ciele wzór siatki. Ubarwienie grzbietu jest szarobrązowe z zielonym odcieniem, boki są jaśniejsze, często złote, a brzuch biały. Płetwy grzbietowa i ogonowa są szarozielone z odrobiną czerwieni, a płetwy odbytowa i brzuszne pomarańczowoczerwone. ",
                Origin = "kleń występuje w jeziorach, rzekach górskich, rzekach średnio nizinnych.",
                Image = new Uri("/img/klen.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Krąp",
                Feeding = "",
                Morpho = "krąpie ryby zewnętrznie bardzo przypomina młodego leszcza - ciało bardzo mocno bocznie ścieśnione, wysokie w stosunku do długości. Pysk jest tępy z wysuwaną paszczą skierowaną ukośnie ku dołowi. Grzbiet jest zielonoszary do zielonoczarnego, boki jaśniejsze. Strona brzuszna biaława do czerwonawej, srebrzyście lśniąca. Płetwy ciemnoszare, nasada płetw piersiowych i brzusznych czerwonawa. ",
                Origin = "na terenie Polski krąp jest bardzo rozpowszechniony, zarówno w rzekach jak i jeziorach nizinnych, zbiornikach zaporowych, rzekach średnich nizinnych, rzekach wielkich nizinnych, gdzie przebywa głównie przy dnie. ",
                Image = new Uri("/img/krap.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Leszcz",
                Feeding = "",
                Morpho = "leszcz ma bardzo mocno bocznie ścieśnione ciało, wysokie w stosunku do długości; płetwa ogonowa głęboko, chorągiewkowato wcięta; głowa mała z wysuwaną paszczą skierowaną ukośnie ku dołowi. Kolor grzbietu jest ołowiany, bądź czarny z charakterystycznym zielonym połyskiem. Boki są zdecydowanie jaśniejsze, metaliczne, a brzuch biały i perłowy (u starszych okazów raczej złocisty). Płetwy nieparzyste ciemnoszare; parzyste jasnoszare.",
                Origin = "leszcz jest gatunkiem powszechnie występującym w polskich wodach, jeziorach, zb. zaporowych, rzekach średnich nizinnych, rzekach wielkich nizinnych, nie występuje jedynie w rzekach górskich oraz zimnych potokach. Ulubiojne miejscówki tej ryby to słabo zasolone wody strefy przyujściowej o słabym nurcie i mulistym dnie.",
                Image = new Uri("/img/leszcz.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Lin",
                Feeding = "",
                Morpho = "liny ryb mają ciało pokryte drobnymi łuskami jest zwarte i mocno zbudowane o szerokim trzonie ogonowym. Otwór gębowy jest poziomy, a w jego kącikach znajduje się po jednym krótkim i miękkim wąsiku. Grzbiet ma najczęściej ma kolor ciemnozielony lub ciemnobrązowy, boki są jaśniejsze i mosiężnie połyskujące, natomiast strona brzuszna żółtawobiała. ",
                Origin = "jeziora, zb. zaporowe, stawy i wyrobiska, rzeki średnie nizinne, rzeki wielkie nizinne.",
                Image = new Uri("/img/lin.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Lipień",
                Feeding = "",
                Morpho = "lipień ma lekko spłaszczone ciało i małą głowę. Otwór gębowy jest niewielki, z drobnymi zębami, szczęka górna jest nieco dłuższa od dolnej i wysunięta do przodu. Lipień posiada charakterystyczne duże łuski, mocno osadzone w skórze. Lipień zwraca uwagę oryginalnym ubarwieniem – u młodych osobników jest ono srebrzysto-jasnozielone z niebieskawymi plamami na bokach, starsze osobniki wyróżniają się szarozielonym grzbietem, zielonkawymi bokami i białym brzuchem, który w okresie tarła przybiera purpurowy odblask. ",
                Origin = "rzeki górskie.",
                Image = new Uri("/img/lipien.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Łosoś",
                Feeding = "",
                Morpho = "łosoś ma ciało wydłużone o smukłym trzonie ogonowym ze stosunkowo małą, spiczastą głową i szerokim wycięciem gębowym, sięgającym tylnej krawędzi oka. Dorosłe osobniki posiadają nieregularne, czarne plamy na górnej połowie ciała. Boki są szarosrebrzyste. ",
                Origin = "łosoś żyje w dwóch środowiskach: początkowo rzeki górskie, rzeki wielkie nizinne; docelowo: morze.",
                Image = new Uri("/img/losos.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Okoń",
                Feeding = "",
                Morpho = "okonie ryby mają ciało wyraźnie wygrzbiecone i pokrywają je drobne, ostre łuski, zachodzące na siebie dachówkowato i bardzo głęboko osadzone w kieszeniach skórnych. Maleńkie ząbki na ich zewnętrznej stronie nadają jego ciału charakterystyczną szorstkość w dotyku. Kości pokrywy skrzelowej posiadają ostry kolec, którym możemy boleśnie się ukłuć. Grzbiet okonia jest najczęściej ciemnoturkusowy, boki zielonożółte, układa się na nich prostopadle od pięciu do dziewięciu charakterystycznych ciemnych smug. ",
                Origin = "stawy i wyrobiska, jeziora, zb. zaporowe, rzeki górskie, rzeki średnie nizinne, rzeki wielkie nizinne, płytkie wody przybrzeżne Bałtyku.",
                Image = new Uri("/img/okon.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Płoć",
                Feeding = "",
                Morpho = "płoć ma ciało mniej lub bardziej wygrzbiecone i ścieśnione w płaszczyznach bocznych. Brzuch jest lekko zaokrąglony na odcinku pomiędzy płetwami brzusznymi, a płetwą odbytową. Najbardziej charakterystycznym znakiem jeśli chodzi o płoć są czerwonawe oczy. Płoć ma wąski pysk, ustawiony prawie w poziomie. Ubarwienie jeśli chodzi o płoć od ciemnozielonego do zielononiebieskiego (grzbiet), boki są srebrzyste z żółtawym połyskiem, z kolei płetwy piersiowe, brzuszne i odbytowa - czerwonawe. ",
                Origin = "płoć występuje w stawach, wyrobiskach, jeziorach, zb. zaporowych, rzekach średnio nizinnych oraz wielko nizinnych.",
                Image = new Uri("/img/ploc.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Pstrąg",
                Feeding = "",
                Morpho = "pstrąg ma ciało o kształcie torpedowatym - ułatwiającym życie w wartkim prądzie rzeki, w zależności od charakteru wody mniej lub bardziej wygrzbiecone i bocznie spłaszczone, z szerokim trzonem ogonowym. Pstrąg ma bardzo zmienne ubarwienie - najczęściej od zielonkawego do brązowawego, zależy od miejsca jego przebywania. Młode osobniki mają duże, wyraźnie niebieskoszare plamy na bokach, natomiast dorosłe liczne, czarne i czerwone kropki oraz żółtobiały lub żółty brzuch. Pstrąg tęczowy ma wydłużone, bocznie nieco spłaszczone ciało o szerokim trzonie ogonowym. Głowa o tępo zakończonym, szeroko wyciętym pysku, podobnie jak ciało i płetwy, usiana jest wieloma, czarnymi plamami i kropkami. ",
                Origin = "pstrąg to zdecydowanie ryba górska, oba jego gatunki żyją w rzekach górskich oraz górnych odcinkach rzek średnich nizinnych. W Polsce najczęściej można je spotkać w południowej i północnej części kraju, wodach: Beskidów, Tatr, Sudetów, Dolnego Śląska, Rudawy, Przemszy, Jury Krakowsko-Częstochowskiej oraz Pomorza Zachodniego i Środkowego, Warmi i Mazur. ",
                Image = new Uri("/img/pstrag.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Sandacz",
                Feeding = "",
                Morpho = "sandacze ryby wyróżniają się zdecydowanie wydłużonym ciałem i małą głową, grzbiet ma zielono-szary kolor, a brzuch jest biały. Jedyną wspólną z popularnym garbusem cechą sandacza, są ciemne, poprzeczne smugi, które występują u tej ryby na bokach ciała. Sandacz wyróżnia się także dwiema stykającymi się ze sobą płetwami grzbietowymi, które rzadko są od siebie oddalone. Do specyficznych cech tej ryby zaliczamy również liczne, ciemne plamy, które zaobserwować można na błonach pomiędzy promieniami płetw grzbietowych i ogonowej. Niesamowity wygląd nadają sandaczowi lekko opalizujące oczy, które w nocy, w świetle latarki, świecą na czerwono. ",
                Origin = "stawy i wszelkiego rodzaju wyrobiska, jeziora, zbiorniki zaporowe, rzeki średnie nizinne, rzeki wielkie nizinne, przybrzeżne strefy Morza Bałtyckiego.",
                Image = new Uri("/img/sandacz.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Sum",
                Feeding = "",
                Morpho = "sum charakteryzuje się przede wszystkim dużą, szeroką i spłaszczoną głową z obszerną paszczą uzbrojoną na brzegach w gęste, liczne i drobne ząbki. Jednak najbardziej zwracają uwagę wąsy suma: dwa najdłuższe, ruchome, wyrastają na szczęce górnej i sięgają aż do płetw piersiowych, cztery krótsze znajdują się na żuchwie. Sum ma nagie ciało, z boków lekko ścieśnione, grzbiet ciemny, oliwkowozielony, brzuch biały, na bokach nieregularne ciemnobrunatne plamy. ",
                Origin = "sum występuje w jeziorach, zb. zaporowych, rzekach średnich nizinnych, rzekach wielkich nizinnych.",
                Image = new Uri("/img/sum.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Szczupak",
                Feeding = "",
                Morpho = "szczupak kiedy płynie, wygląda jak „wodna strzała”. Tułów szczupaka wydłużony, mocno przewężony przed nasadą płetwy ogonowej, głowa z przodu spłaszczona, płetwa grzbietowa przesunięta w tył, aż nad płetwę odbytową. Szczupak ma ciało mało elastyczne, dlatego pływa i atakuje przeważnie w linii prostej, czasami szerokim łukiem. Być może przyczyną tego „usztywnienia” są silnie rozwinięte mięśnie tułowia, niezbędne jednak do przezwyciężenia dużej siły bezwładności ciała. Szczupak startuje przecież do ataku z miejsca i to w ułamku sekundy, napotyka więc od razu na duży opór wody. ",
                Origin = "szczupak występuje w stawach i wyrobiskach, jeziorach, zb. zaporowych, rzekach średnio nizinnych, rzekach wielkich nizinnych.",
                Image = new Uri("/img/szczupak.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Tołpyga",
                Feeding = "",
                Morpho = "tołpyga ma wyciągnięte ciało, wydłużone, owalne w przekroju, linia boczna wyraźna lekko zakrzywiona do dołu. Głowa jest szeroka i spiczasta, tępo zakończona z małą paszczą skierowaną skośnie ku górze. Oczy małe i nisko osadzone.",
                Origin = "stawy, wyrobiska i jeziora.",
                Image = new Uri("/img/tolpyga.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Troć",
                Feeding = "",
                Morpho = "troć jest wędrowną formą pstrąga potokowego. Jeśli chodzi o ubarwienie, to troć ma grzbiet szarawy lub brązowawy, boki jaśniejsze, a brzuch srebrzysty. Głowa boki i grzbiet są pokryte licznymi, czarnymi plamkami, które w czasie tarła mają żółtą obwódkę. Płetwa tłuszczowa jest czerwono obrzeżona. ",
                Origin = "troć żyje w dwóch środowiskach: początkowo rzeki górskie, rzeki wielkie nizinne; docelowo: morze.",
                Image = new Uri("/img/troc.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Ukleja",
                Feeding = "",
                Morpho = "Ukleja posiada wydłużone, ścieśnione bocznie ciało; linia boczna jest wyraźna i lekko zakrzywiona do dołu; głowa mała z paszczą skierowaną ku górze. Grzbiet ma stalowozielony kolor, boki są srebrzystobiałe, połyskujące, a płetwy grzbietowa i ogonowa szare lub bezbarwne.",
                Origin = "stawy i wyrobiska, jeziora, zb. zaporowe, rzeki średnie nizinne, rzeki wielkie nizinne.",
                Image = new Uri("/img/ukleja.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Węgorz",
                Feeding = "",
                Morpho = "długi wężowaty tułów, za otworem odbytowym spłaszczony bocznie, końcowy pysk uzbrojony w kilka rzędów ostrych zębów. Grzbiet jest ciemny, brązowy lub zielony, boki jaśniejsze, brzuch brudnobiały. Występują dwa typy węgorzy: szerokogłowe i wąskogłowe, jednak nie jest do końca wyjaśnione, co jest przyczyną powstawania tych różnic i na jakim etapie rozwoju one powstają. Węgorz jest krótkowidzem, stąd funkcję jednego z głównych informatorów o otaczającym go środowisku przejął węch. ",
                Origin = "stawy i wyrobiska, jeziora, zb. zaporowe, rzeki górskie, rzeki średnie nizinne, rzeki wielkie nizinne, płytkie wody przybrzeżne Bałtyku, otwarte morze.",
                Image = new Uri("/img/wegorz.jpg", UriKind.Relative)
            });
            ListFish.Add(new Fish()
            {
                Id = numOfObject++,
                Name = "Wzdręga",
                Feeding = "",
                Morpho = "wzdręgi ryby zewnętrzną budową przypomina płoć, charakterystyczną różnicą jest kolor płetw - jasnoczerwony. Ciało brzany jest wygrzbiecione i ścieśnione po bokach. Otwór gębowy jest wąski, skośnie skierowany ku górze. Grzbiet oraz wierzchnia część głowy są zielonoszare do zielonobrązowych, a boki jaśniejsze o mosiężnym połysku. Płetwy brzuszne, odbytowa i grzbietowa w charakterystycznym, mocnym, pomarańczowym do krwistoczerwonego odcieniu. U nasady w kolorze od brązowawego do szarego.",
                Origin = "wzdręga występuje w Europie Zachodniej, Środkowej, północnych Włoszech i na Bałkanach. W Polsce można ją spotkać w jeziorach, rzekach wielkich nizinnych, gdzie preferuje spokojne wody o mulistym p",
                Image = new Uri("/img/wzdrega.jpg", UriKind.Relative)
            });
        }
       
        private Fish _selctedItem;
        public Fish select 
        {
            get 
            {
                return _selctedItem;
            }
            set 
            {
                var oldValu = _selctedItem;
                _selctedItem = value;
                changeValue("select");
            }
        }
    }
}
