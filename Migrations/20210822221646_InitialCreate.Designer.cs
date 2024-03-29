﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Api.Persistence;

namespace Api.Migrations
{
    [DbContext(typeof(NewsDbContext))]
    [Migration("20210822221646_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Api.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "business",
                            Description = "Minister of Finance Israel Katz is forming a new plan as the unpaid leave payments are due to be cut next month.",
                            Image = "https://images.globes.co.il/images/NewGlobes/big_image_800/2018/9CAD617B01EF4A842E7F9751814216FD_800x392.20181108T181028.jpg",
                            Title = "Unemployment in Israel falls to 8%"
                        },
                        new
                        {
                            Id = 2,
                            Category = "business",
                            Description = "The Israeli web behavior and traffic analytics company's founder and CEO Or Offer will sell shares worth $10 million.",
                            Image = "https://res.cloudinary.com/globes/image/upload/t_desktop_article_content_header_800*392/v1603799749/COT_Pic/%D7%90%D7%95%D7%A8_%D7%A2%D7%95%D7%A4%D7%A8_%D7%A7%D7%A8%D7%99%D7%98_-_%D7%A8%D7%95%D7%AA%D7%9D_%D7%9B%D7%A0%D7%A2%D7%A0%D7%99_pl9zyo.jpg",
                            Title = "Similarweb files to raise $150m on NYSE at $1.5b valuation"
                        },
                        new
                        {
                            Id = 3,
                            Category = "business",
                            Description = "The Israeli e-commerce company has developed a platform that allows communication with buyers in 25 languages and purchases in more than 100 currencies while calculating local sales taxes.",
                            Image = "https://images.globes.co.il/Images/NewGlobes/big_image/2014/c28_stock-575.jpg",
                            Title = "Global-E files for Nasdaq IPO at $3.5b valuation"
                        },
                        new
                        {
                            Id = 4,
                            Category = "business",
                            Description = "With El Al competing with Delta, United and American Airlines this summer, there will be 10 daily flights alone between Tel Aviv and New York.",
                            Image = "https://images.globes.co.il/images/NewGlobes/big_image_800/2020/800x392.2020618T135158.jpg",
                            Title = "El Al adding flights on Tel Aviv - US routes"
                        },
                        new
                        {
                            Id = 5,
                            Category = "business",
                            Description = "The cumulative deficit for the twelve months to the end of May was NIS 149.2 billion, or 10.5% of GDP.",
                            Image = "https://res.cloudinary.com/globes/image/upload/t_desktop_article_content_header_800*392/v1596469388/old/1666917.jpg",
                            Title = "Israel's fiscal deficit narrows as gov't revenues rise"
                        },
                        new
                        {
                            Id = 6,
                            Category = "entertainment",
                            Description = "Photographer Yehoshua Shuka Glotman documented the joyous scenes at the Rashbi’s tomb for almost 40 years, captivated by the atmosphere there. A new book showcases his images from the annual events, prior to last week’s tragedy",
                            Image = "https://www.haaretz.com/polopoly_fs/1.9766723.1619960630!/image/2697928942.jpg_gen/derivatives/landscape_108/2697928942.jpg",
                            Title = "In photos: Mount Meron celebration over the years"
                        },
                        new
                        {
                            Id = 7,
                            Category = "entertainment",
                            Description = "Educators at this unique Jaffa school – where 40 percent of the pupils are Arab – found new ways to defuse tensions, fear and harsh rhetoric between the pupils",
                            Image = "https://www.haaretz.com/polopoly_fs/1.9878672.1623053744!/image/1031031464.jpg_gen/derivatives/landscape_108/1031031464.jpg",
                            Title = "What it's like studying in an Arab-Jewish school during a war"
                        },
                        new
                        {
                            Id = 8,
                            Category = "entertainment",
                            Description = "The modern Jewish holiday may be synonymous with cheesecake, cheese platters and other dairy-based products, but Shavuot meals in the Middle East and North Africa were far meatier affairs",
                            Image = "https://www.haaretz.com/polopoly_fs/1.9809270.1620997461!/image/2522396801.jpg_gen/derivatives/landscape_108/2522396801.jpg",
                            Title = "Preparing for a nondairy Shavuot, just like some Jews have done for centuries"
                        },
                        new
                        {
                            Id = 9,
                            Category = "entertainment",
                            Description = "Rapper Sameh 'Saz' Zakout and Uriya Rosenman tackle racism in Israel in video produced as part of project promoting dialogue between Arabs and Jews",
                            Image = "https://www.haaretz.com/polopoly_fs/1.9828844.1621536237!/image/748109202.png_gen/derivatives/landscape_108/748109202.png",
                            Title = "A Jew and an Arab confront Israeli prejudice in ‘I’m Not Racist’ reimagining"
                        },
                        new
                        {
                            Id = 10,
                            Category = "entertainment",
                            Description = "The current round of fighting ignited a virtual powder keg, with developers and gamers slamming Israel fiercely. Even the veteran gaming site IGN was caught up in the fray",
                            Image = "https://www.haaretz.com/polopoly_fs/1.9827711.1621516720!/image/2449330690.jpg_gen/derivatives/landscape_108/2449330690.jpg",
                            Title = "Israel is losing on a new front: The gaming world"
                        },
                        new
                        {
                            Id = 11,
                            Category = "science",
                            Description = "Paleontologists found the pierced skull of a cave bear in a Siberian cave. It could have been caused naturally – or may have been made for ritual purposes",
                            Image = "https://www.haaretz.com/polopoly_fs/1.9885374.1623156981!/image/3923841999.jpg_gen/derivatives/landscape_108/3923841999.jpg",
                            Title = "Case closed: 35,000-year-old murder of a bear finally solved"
                        },
                        new
                        {
                            Id = 12,
                            Category = "science",
                            Description = "The stretch found in Jerusalem’s City of David ends the dispute about whether previously unearthed structures were part of the city wall, but doesn’t help elucidate who exactly built it or why",
                            Image = "https://www.haaretz.com/polopoly_fs/1.9998937.1626261788!/image/3470578436.jpg_gen/derivatives/landscape_108/3470578436.jpg",
                            Title = "Israeli archaeologists find new section of Jerusalem’s ancient defensive wall"
                        },
                        new
                        {
                            Id = 13,
                            Category = "science",
                            Description = "In Europe, raw pet food turned out to be laden with antibiotic-resistant bacteria; in Israel, such fripperies are banned outright",
                            Image = "https://www.haaretz.com/polopoly_fs/1.9995083.1626158448!/image/3836504835.jpg_gen/derivatives/landscape_108/3836504835.jpg",
                            Title = "Raw dog foods are a superbug hazard, researchers warn"
                        },
                        new
                        {
                            Id = 14,
                            Category = "science",
                            Description = "Work performed by non-medical staff has ground to a halt, but facilities such as emergency rooms, oncology departments, dialysis, maternity and premature infant wards are functioning normally",
                            Image = "https://www.haaretz.com/polopoly_fs/1.9999760.1626268427!/image/2988996833.jpg_gen/derivatives/landscape_108/2988996833.jpg",
                            Title = "Garbage overflows, surgeries delayed: support staff strike in hospitals takes its toll"
                        },
                        new
                        {
                            Id = 15,
                            Category = "science",
                            Description = "As millions around the globe desperately seek coronavirus vaccines, Israel's transportation and tourism ministries are hoping to find ways to open the economy and the tourism industry",
                            Image = "https://www.haaretz.com/polopoly_fs/1.9791083.1620655369!/image/1805404839.jpg_gen/derivatives/landscape_108/1805404839.jpg",
                            Title = "COVID and Israel: country wants to sell its vaccines to a luxury cruise line"
                        },
                        new
                        {
                            Id = 16,
                            Category = "health",
                            Description = "The U.S. Food and Drug Administration is expected to authorize Pfizer’s COVID-19 vaccine for young adults age 12 and older by next week, according to a federal official and a person familiar with the process, setting up shots for many before the beginning of the next school year.",
                            Image = "https://static.foxnews.com/foxnews.com/content/uploads/2020/05/iStock-1127763296.jpg",
                            Title = "FDA expected to OK Pfizer vaccine for teens within week"
                        },
                        new
                        {
                            Id = 17,
                            Category = "health",
                            Description = "India's government faced calls for a strict lockdown to slow a devastating surge in new coronavirus cases, and a court in New Delhi on Wednesday will decide whether to punish officials for failing to end a 2-week-old erratic supply of oxygen to overstretched hospitals.",
                            Image = "https://static.foxnews.com/foxnews.com/content/uploads/2021/05/INDIA_COVID_CRISIS_AP.jpg",
                            Title = "Indian government faces coronavirus lockdown calls, contempt charges"
                        },
                        new
                        {
                            Id = 18,
                            Category = "health",
                            Description = "Desglosamos los signos, causas y tratamientos para cinco de los síntomas más comunes de estas etapas.",
                            Image = "https://static01.nyt.com/images/2021/04/27/well/27Well-sidebar-top/27Well-sidebar-top-moth.jpg",
                            Title = "Perimenopausia: síntomas, causas y tratamientos"
                        },
                        new
                        {
                            Id = 19,
                            Category = "health",
                            Description = "Más de mil millones de mujeres de todo el mundo habrán experimentado la perimenopausia para 2025, pero aún no tenemos una cultura para saber más al respecto.",
                            Image = "https://static01.nyt.com/images/2021/04/27/well/27Well-perimenopause-esp-1/27Well-perimenopause-moth.jpg",
                            Title = "‘Nadie me dijo que sería así’: la perimenopausia sigue siendo un misterio"
                        },
                        new
                        {
                            Id = 20,
                            Category = "health",
                            Description = "Over half of parents surveyed in a national poll said it was unlikely their child would receive a COVID-19 vaccine should the shots see expanded authorization in younger age groups.",
                            Image = "https://static.foxnews.com/foxnews.com/content/uploads/2021/07/5822b8b8-child_vaccine_istock.jpg",
                            Title = "Parents split on COVID-19 vaccine for young kids, poll finds"
                        },
                        new
                        {
                            Id = 21,
                            Category = "technology",
                            Description = "The company tells Apple users that tracking helps keep those platforms “free of charge,” but opting out now doesn't mean paying up later.",
                            Image = "https://media.wired.com/photos/60904bed68d4596874a4fd14/master/pass/Sec_Facebook_2CK6JT6.jpg",
                            Title = "Don’t Buy Into Facebook’s Ad-Tracking Pressure on iOS 14.5"
                        },
                        new
                        {
                            Id = 22,
                            Category = "technology",
                            Description = "Apple and Epic Games, maker of the wildly popular game Fortnite, square off on Monday in a trial that could decide how much control Apple can exert over the app economy.",
                            Image = "https://static01.nyt.com/images/2021/04/29/business/29epicapple/01epicapple-moth.jpg",
                            Title = "Apple and Epic Head to Court Over Their Slices of the App Pie"
                        },
                        new
                        {
                            Id = 23,
                            Category = "technology",
                            Description = "The ProWritingAid Lifetime Subscription Bundle includes an app that gives you stylistic advice.",
                            Image = "https://s.yimg.com/os/creatr-uploaded-images/2021-06/30f74ac0-c3b2-11eb-9fef-1179789fe80c",
                            Title = "Improve your writing with this award-winning productivity software package"
                        },
                        new
                        {
                            Id = 24,
                            Category = "technology",
                            Description = "The update has been a long time coming, and if you haven't played, now's the time. We asked Robert Kurvitz, the game's designer, if he’s finally satisfied with it.",
                            Image = "https://media.wired.com/photos/60ba714770d107b3e767d59e/master/pass/games_disco-elysium.jpg",
                            Title = "The Incredible, Absurd World of Disco Elysium: The Final Cut"
                        },
                        new
                        {
                            Id = 25,
                            Category = "technology",
                            Description = "It’s been almost a decade since Leon Panetta, then the secretary of defense, warned of an impending “Cyber Pearl Harbor.” He didn’t want to be right.",
                            Image = "https://static01.nyt.com/images/2021/06/05/business/05cyber-pearlharbor1/05cyber-pearlharbor1-moth.jpg",
                            Title = "Are We Waiting for Everyone to Get Hacked?"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
