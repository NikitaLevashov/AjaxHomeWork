﻿// <auto-generated />
using ListShopsDAL.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ListShopsDAL.Migrations
{
    [DbContext(typeof(ShopsDBContext))]
    partial class ShopsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ListShopsDAL.Models.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OperatingMode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "«Евроопт» на улице Монтажников (промузел Западный) открылся в 2008 году и стал первым в Беларуси ТЦ формата гипердискаунтер. Его особенности — ангарная архитектура, аскетичный интерьер, упрощенная выкладка товаров. Часть стеллажей используется как альтернатива складским помещениям. В торговом зале 35 тыс. наименований товаров, покупателей могут одновременно обслуживать 64 кассы. К гипермаркету примыкают магазин бытовой техники «Техно Плюс» и торговая галерея с магазинами обуви, одежды, косметики и товаров для дома.",
                            Name = "Евроопт",
                            OperatingMode = "9:00 - 23:00"
                        },
                        new
                        {
                            Id = 2,
                            Description = "«Новая Европа» открылась весной 2011 года, дополнив собой вереницу разнообразных остекленных зданий на нечетной стороне улицы Сурганова. Непосредственно торгово-развлекательный центр занимает первые три этажа. Здесь более сотни брендовых магазинов, несколько кафе, пиццерия, бильярдный клуб, гейм-зона, аттракционы для детей. Выше находятся офисы.",
                            Name = "Новая Европа",
                            OperatingMode = "9:00 - 23:00"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Спустя 8 лет после открытия «Корона» на улице Кальварийской остается самым центральным гипермаркетом Минска. Это первый представитель торговых комплексов так называемого третьего поколения, для которых характерно наличие крупного якорного арендатора и просторной торговой галереи. Первый этаж занимает продовольственный гипермаркет, радующий посетителей бесплатными пакетами, а также два объекта общепита. Второй этаж отведен под галерею магазинов «Модный молл», магазин «Корона Техно» и детский развлекательный центр.",
                            Name = "Корона",
                            OperatingMode = "0:00 - 24:00"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Комплекс на пересечении улиц Притыцкого и Глебки получил свое название благодаря оригинальному экстерьеру: по замыслу архитекторов стеновые панели на фасаде придают зданию вид каменистого склона. Над проектом работали специалисты из Вильнюса.",
                            Name = "Скала",
                            OperatingMode = "9:00-23:00"
                        },
                        new
                        {
                            Id = 5,
                            Description = "За рубежом давно научились извлекать выгоду из совмещения крупных транспортных узлов с торгово-развлекательными центрами. «Галилео» — пример воплощения этой тенденции в Минске. Впечатляющее своими размерами здание возведено на месте старого автовокзала «Центральный». Комплекс по адресу ул. Бобруйская, 6, объединяет под одной крышей новый вокзал, административно-офисную часть, семиэтажный торгово-развлекательный центр и паркинг почти на 500 машин.",
                            Name = "Галилео",
                            OperatingMode = "0:00-23:00"
                        },
                        new
                        {
                            Id = 6,
                            Description = "От других крупнейших торговых центров Минска «Град» на улице Тимирязева отличается своей специализацией. На 2—5-м этажах расположены более 300 магазинов по продаже мебели, сантехники, строительно-отделочных материалов и аксессуаров. 6-й этаж выполняет развлекательную функцию: боулинг на восемь дорожек, ресторан, детский центр «Космо». 7-й этаж занимает бильярдный клуб «Шпиль».",
                            Name = "Град",
                            OperatingMode = "9:00-22:00"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Наряду с Национальной библиотекой подземный торговый центр «Столица» стал одной из главных минских строек минувшего десятилетия. Громадный котлован, глубина которого местами достигала 20 метров, на площади Независимости вырыли в 2003 году. А 31 декабря 2006-го состоялось торжественное открытие «Столицы». В подземном комплексе три этажа отданы под торговлю и общественное питание. Достаточно много помещений арендуют белорусские производители одежды, обуви, продуктов и алкоголя. В центральной части ТЦ расположен атриум, под куполом которого регулярно проходят концерты, презентации и другие праздничные мероприятия",
                            Name = "Столица",
                            OperatingMode = "10:00- 22:00"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Bigzz открылся 10 марта 2005 года и стал первым минским гипермаркетом. По данным Colliers International, это был первый объект в Беларуси, отвечавший сложившимся за рубежом требованиям к торгово-развлекательным центрам, хотя в таком формате он заработал не в полной мере: так и не был запущен в эксплуатацию многозальный кинотеатр. ТРЦ «Экспобел» сегодня — это гипермаркет, супермаркет бытовой техники и электроники, более 70 магазинов, отделения нескольких банков, салон красоты, рестораны, боулинг-клуб на 16 дорожек, два детских развлекательных центра и казино",
                            Name = "Экспобел",
                            OperatingMode = "9:00-23:00"
                        },
                        new
                        {
                            Id = 9,
                            Description = "ТРЦ Юрия Чижа «Арена-Сити», закрывший жителям элитных домов вид на проспект Победителей, занимает почетную вторую строку нашего рейтинга. На четырех этажах находятся супермаркеты ProStore и «Электросила», около 80 магазинов-бутиков, ресторан, фуд-корт на 470 посадочных мест. Паркинг вмещает около 1500 автомобилей. А вот анонсированный ранее кинотеатр с шестью залами и зоной отдыха в составе «Арена-Сити» пока так и не заработал. Открыть его обещают в январе 2015 года.",
                            Name = "Арена-Сити",
                            OperatingMode = "8:00 - 22:00"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Крупнейший торгово-развлекательный центр Минска и всей Беларуси облагородил собой проспект Победителей напротив выставочного комплекса «БелЭкспо» и новой резиденции президента. Громадное здание имеет весьма своеобразную архитектуру, сочетающую элементы средневекового замка и современного бизнес-центра. Решение довольно неоднозначное, но по итогам 2012 года Минстройархитектуры признало объект бизнесмена Павла Топузидиса одним из лучших в Минске.",
                            Name = "Замок",
                            OperatingMode = "9:00 - 23:00"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
