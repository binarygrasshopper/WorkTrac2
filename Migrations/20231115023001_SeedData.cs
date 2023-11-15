using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkTrac.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Avatar", "Department", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "https://robohash.org/velestvoluptatem.png?size=100x100&set=set1", "Marketing", "pivanusyev0@admin.ch", "Pooh", "Ivanusyev" },
                    { 2, "https://robohash.org/sitsitnulla.png?size=100x100&set=set1", "Training", "ptrump1@examiner.com", "Parke", "Trump" },
                    { 3, "https://robohash.org/rationequoarchitecto.png?size=100x100&set=set1", "Sales", "agyppes2@cyberchimps.com", "Alvina", "Gyppes" },
                    { 4, "https://robohash.org/blanditiisfugiatipsam.png?size=100x100&set=set1", "Product Management", "evasyutin3@tamu.edu", "Ellissa", "Vasyutin" },
                    { 5, "https://robohash.org/aliquidsuntinventore.png?size=100x100&set=set1", "Services", "cdavy4@chicagotribune.com", "Cordelia", "Davy" },
                    { 6, "https://robohash.org/illoinciduntatque.png?size=100x100&set=set1", "Accounting", "aglide5@furl.net", "Aristotle", "Glide" },
                    { 7, "https://robohash.org/odioquinemo.png?size=100x100&set=set1", "Human Resources", "earran6@rambler.ru", "Elisabetta", "Arran" },
                    { 8, "https://robohash.org/utautmolestiae.png?size=100x100&set=set1", "Research and Development", "lbuncom7@xing.com", "Lesley", "Buncom" },
                    { 9, "https://robohash.org/debitisetcorporis.png?size=100x100&set=set1", "Services", "tcaselick8@amazon.com", "Tedd", "Caselick" },
                    { 10, "https://robohash.org/utminimafugit.png?size=100x100&set=set1", "Support", "ocoggles9@time.com", "Orella", "Coggles" },
                    { 11, "https://robohash.org/estautmagnam.png?size=100x100&set=set1", "Support", "zmalliona@paypal.com", "Zabrina", "Mallion" },
                    { 12, "https://robohash.org/voluptatessolutaipsa.png?size=100x100&set=set1", "Legal", "kdarreeb@yellowpages.com", "Kate", "Darree" },
                    { 13, "https://robohash.org/quiullamblanditiis.png?size=100x100&set=set1", "Marketing", "rdanilovichc@forbes.com", "Ringo", "Danilovich" },
                    { 14, "https://robohash.org/autaenim.png?size=100x100&set=set1", "Support", "imcsporrind@pagesperso-orange.fr", "Ina", "McSporrin" },
                    { 15, "https://robohash.org/corruptiquidemconsectetur.png?size=100x100&set=set1", "Marketing", "egulleforde@zimbio.com", "Ellsworth", "Gulleford" },
                    { 16, "https://robohash.org/voluptasullamdebitis.png?size=100x100&set=set1", "Marketing", "srivelf@google.com.hk", "Say", "Rivel" },
                    { 17, "https://robohash.org/consequatursitmollitia.png?size=100x100&set=set1", "Marketing", "snowlandg@ask.com", "Samuel", "Nowland" },
                    { 18, "https://robohash.org/architectonesciuntmagni.png?size=100x100&set=set1", "Product Management", "kmartignonh@dmoz.org", "Katya", "Martignon" },
                    { 19, "https://robohash.org/velsedmolestiae.png?size=100x100&set=set1", "Services", "llenormandi@wiley.com", "Leshia", "Lenormand" },
                    { 20, "https://robohash.org/perspiciatissuntdolorum.png?size=100x100&set=set1", "Services", "uwelshj@mapquest.com", "Ursuline", "Welsh" },
                    { 21, "https://robohash.org/doloreducimusin.png?size=100x100&set=set1", "Human Resources", "ochaucerk@cafepress.com", "Olympia", "Chaucer" },
                    { 22, "https://robohash.org/quiipsalaboriosam.png?size=100x100&set=set1", "Accounting", "kbillingsleyl@free.fr", "Kerri", "Billingsley" },
                    { 23, "https://robohash.org/repudiandaeetnostrum.png?size=100x100&set=set1", "Sales", "byaldrenm@census.gov", "Brand", "Yaldren" },
                    { 24, "https://robohash.org/nonsitest.png?size=100x100&set=set1", "Services", "mbletchern@unesco.org", "Munroe", "Bletcher" },
                    { 25, "https://robohash.org/accusamusveniameligendi.png?size=100x100&set=set1", "Engineering", "mbetjeso@yellowpages.com", "Moina", "Betjes" },
                    { 26, "https://robohash.org/possimusvoluptatemodit.png?size=100x100&set=set1", "Engineering", "ryukhnevichp@moonfruit.com", "Riva", "Yukhnevich" },
                    { 27, "https://robohash.org/quoquianon.png?size=100x100&set=set1", "Services", "amcateerq@usgs.gov", "Alard", "McAteer" },
                    { 28, "https://robohash.org/quodenimnisi.png?size=100x100&set=set1", "Human Resources", "smaddinr@wired.com", "Sadella", "Maddin" },
                    { 29, "https://robohash.org/sintveritatisminus.png?size=100x100&set=set1", "Services", "sbrusles@senate.gov", "Steven", "Brusle" },
                    { 30, "https://robohash.org/accusamusvoluptasillo.png?size=100x100&set=set1", "Support", "aleishmant@yellowbook.com", "Arv", "Leishman" },
                    { 31, "https://robohash.org/eligendinonquia.png?size=100x100&set=set1", "Training", "rplaschkeu@4shared.com", "Reinaldo", "Plaschke" },
                    { 32, "https://robohash.org/atquealiasdoloremque.png?size=100x100&set=set1", "Legal", "istillyv@sbwire.com", "Iorgos", "Stilly" },
                    { 33, "https://robohash.org/illumofficianam.png?size=100x100&set=set1", "Engineering", "tricciardiellow@bbc.co.uk", "Terrell", "Ricciardiello" },
                    { 34, "https://robohash.org/sitetlabore.png?size=100x100&set=set1", "Engineering", "scasillisx@oaic.gov.au", "Sybille", "Casillis" },
                    { 35, "https://robohash.org/nullavelitconsequatur.png?size=100x100&set=set1", "Product Management", "jgooddingy@dropbox.com", "Jobye", "Goodding" },
                    { 36, "https://robohash.org/maximeutimpedit.png?size=100x100&set=set1", "Product Management", "cwinfieldz@ted.com", "Cleve", "Winfield" },
                    { 37, "https://robohash.org/eosetmolestiae.png?size=100x100&set=set1", "Research and Development", "edotson10@alibaba.com", "Ernst", "Dotson" },
                    { 38, "https://robohash.org/verocumqueest.png?size=100x100&set=set1", "Support", "dvansalzberger11@php.net", "Denny", "Van Salzberger" },
                    { 39, "https://robohash.org/iureaveritatis.png?size=100x100&set=set1", "Legal", "bpetru12@merriam-webster.com", "Benn", "Petru" },
                    { 40, "https://robohash.org/quidemmolestiaelaborum.png?size=100x100&set=set1", "Training", "hdreigher13@businessweek.com", "Helen", "Dreigher" },
                    { 41, "https://robohash.org/etperferendisquis.png?size=100x100&set=set1", "Engineering", "caubrey14@businesswire.com", "Cosimo", "Aubrey" },
                    { 42, "https://robohash.org/temporibuseaid.png?size=100x100&set=set1", "Legal", "barran15@unblog.fr", "Barry", "Arran" },
                    { 43, "https://robohash.org/quisitomnis.png?size=100x100&set=set1", "Services", "shatchette16@cbsnews.com", "Sabra", "Hatchette" },
                    { 44, "https://robohash.org/errordoloremquetempora.png?size=100x100&set=set1", "Training", "vsabathe17@prnewswire.com", "Vinnie", "Sabathe" },
                    { 45, "https://robohash.org/sintevenietvel.png?size=100x100&set=set1", "Accounting", "tgranleese18@wufoo.com", "Townsend", "Granleese" },
                    { 46, "https://robohash.org/solutaidsunt.png?size=100x100&set=set1", "Sales", "aislip19@abc.net.au", "Aila", "Islip" },
                    { 47, "https://robohash.org/magnamassumendaautem.png?size=100x100&set=set1", "Training", "dferryn1a@mashable.com", "Dierdre", "Ferryn" },
                    { 48, "https://robohash.org/eumquisporro.png?size=100x100&set=set1", "Business Development", "sblackmoor1b@joomla.org", "Sharyl", "Blackmoor" },
                    { 49, "https://robohash.org/sapienteipsaconsequatur.png?size=100x100&set=set1", "Research and Development", "lmeriel1c@soundcloud.com", "Lisetta", "Meriel" },
                    { 50, "https://robohash.org/utsuntqui.png?size=100x100&set=set1", "Sales", "seble1d@slashdot.org", "Shelby", "Eble" },
                    { 51, "https://robohash.org/suscipitquamquo.png?size=100x100&set=set1", "Services", "snisen1e@github.io", "Shela", "Nisen" },
                    { 52, "https://robohash.org/consecteturquiexpedita.png?size=100x100&set=set1", "Business Development", "cnelius1f@cnet.com", "Cristi", "Nelius" },
                    { 53, "https://robohash.org/accusamusautemlaborum.png?size=100x100&set=set1", "Training", "ldavidowich1g@walmart.com", "Leticia", "Davidowich" },
                    { 54, "https://robohash.org/quidemsuntmaiores.png?size=100x100&set=set1", "Engineering", "jionnidis1h@cnbc.com", "Joete", "Ionnidis" },
                    { 55, "https://robohash.org/enimestaut.png?size=100x100&set=set1", "Research and Development", "ggayle1i@issuu.com", "Georgeta", "Gayle" },
                    { 56, "https://robohash.org/omnisetdistinctio.png?size=100x100&set=set1", "Product Management", "npercy1j@fotki.com", "Nicolais", "Percy" },
                    { 57, "https://robohash.org/nihilvoluptatumab.png?size=100x100&set=set1", "Accounting", "jloughton1k@digg.com", "Joellyn", "Loughton" },
                    { 58, "https://robohash.org/nequeabquidem.png?size=100x100&set=set1", "Business Development", "dbretton1l@omniture.com", "Davie", "Bretton" },
                    { 59, "https://robohash.org/autaliasquo.png?size=100x100&set=set1", "Sales", "sdabbotdoyle1m@arstechnica.com", "Saree", "D'Abbot-Doyle" },
                    { 60, "https://robohash.org/etveniameum.png?size=100x100&set=set1", "Research and Development", "hgloves1n@sun.com", "Hobie", "Gloves" },
                    { 61, "https://robohash.org/itaqueenimtemporibus.png?size=100x100&set=set1", "Support", "vweerdenburg1o@arstechnica.com", "Vanessa", "Weerdenburg" },
                    { 62, "https://robohash.org/veniamautautem.png?size=100x100&set=set1", "Accounting", "gledwitch1p@twitter.com", "Grove", "Ledwitch" },
                    { 63, "https://robohash.org/quiofficiaunde.png?size=100x100&set=set1", "Product Management", "gpoe1q@cafepress.com", "Gary", "Poe" },
                    { 64, "https://robohash.org/officiisnullavel.png?size=100x100&set=set1", "Engineering", "ydussy1r@home.pl", "Yolane", "Dussy" },
                    { 65, "https://robohash.org/estaliquidmagnam.png?size=100x100&set=set1", "Services", "mmcentegart1s@spiegel.de", "Mirna", "McEntegart" },
                    { 66, "https://robohash.org/voluptassuscipitut.png?size=100x100&set=set1", "Research and Development", "spickless1t@merriam-webster.com", "Sarene", "Pickless" },
                    { 67, "https://robohash.org/quisrepudiandaenisi.png?size=100x100&set=set1", "Accounting", "amatyugin1u@phpbb.com", "Ashley", "Matyugin" },
                    { 68, "https://robohash.org/utitaqueenim.png?size=100x100&set=set1", "Engineering", "umintoft1v@joomla.org", "Ursa", "Mintoft" },
                    { 69, "https://robohash.org/isteetautem.png?size=100x100&set=set1", "Marketing", "vrockcliff1w@umn.edu", "Valera", "Rockcliff" },
                    { 70, "https://robohash.org/inquiomnis.png?size=100x100&set=set1", "Product Management", "bbohea1x@liveinternet.ru", "Brad", "Bohea" },
                    { 71, "https://robohash.org/aspernaturveroea.png?size=100x100&set=set1", "Sales", "smathissen1y@soup.io", "Star", "Mathissen" },
                    { 72, "https://robohash.org/optiodelenitisoluta.png?size=100x100&set=set1", "Accounting", "hyoud1z@berkeley.edu", "Heather", "Youd" },
                    { 73, "https://robohash.org/rerumvoluptasminima.png?size=100x100&set=set1", "Training", "mcraythorne20@paginegialle.it", "Meredith", "Craythorne" },
                    { 74, "https://robohash.org/corruptivoluptatemrepudiandae.png?size=100x100&set=set1", "Services", "akenion21@360.cn", "Austin", "Kenion" },
                    { 75, "https://robohash.org/corporisearumdolor.png?size=100x100&set=set1", "Marketing", "cbradneck22@psu.edu", "Cosette", "Bradneck" },
                    { 76, "https://robohash.org/distinctiofugiataliquid.png?size=100x100&set=set1", "Product Management", "ttrimble23@miitbeian.gov.cn", "Terra", "Trimble" },
                    { 77, "https://robohash.org/idveritatisvel.png?size=100x100&set=set1", "Support", "rcaras24@ow.ly", "Roseanna", "Caras" },
                    { 78, "https://robohash.org/nihilrepellatprovident.png?size=100x100&set=set1", "Product Management", "jmichelle25@soup.io", "Johna", "Michelle" },
                    { 79, "https://robohash.org/aliquamiustooccaecati.png?size=100x100&set=set1", "Legal", "hlindholm26@ft.com", "Harland", "Lindholm" },
                    { 80, "https://robohash.org/iustoetlibero.png?size=100x100&set=set1", "Services", "aconcannon27@xinhuanet.com", "Allayne", "Concannon" },
                    { 81, "https://robohash.org/eumomnisdolor.png?size=100x100&set=set1", "Support", "ldoerr28@marketwatch.com", "Lenna", "Doerr" },
                    { 82, "https://robohash.org/abquosea.png?size=100x100&set=set1", "Marketing", "ejenckes29@skype.com", "Edan", "Jenckes" },
                    { 83, "https://robohash.org/estadipisciquos.png?size=100x100&set=set1", "Product Management", "lpaffett2a@toplist.cz", "Luciano", "Paffett" },
                    { 84, "https://robohash.org/idplaceatnumquam.png?size=100x100&set=set1", "Marketing", "hgatteridge2b@geocities.com", "Hazlett", "Gatteridge" },
                    { 85, "https://robohash.org/autemestet.png?size=100x100&set=set1", "Business Development", "mlauga2c@cocolog-nifty.com", "Merrili", "Lauga" },
                    { 86, "https://robohash.org/etvoluptatumillo.png?size=100x100&set=set1", "Sales", "kbeeho2d@github.com", "Kris", "Beeho" },
                    { 87, "https://robohash.org/temporibusnatuset.png?size=100x100&set=set1", "Services", "cpetrescu2e@nps.gov", "Carolyne", "Petrescu" },
                    { 88, "https://robohash.org/autemquiavoluptas.png?size=100x100&set=set1", "Product Management", "eberget2f@163.com", "Edith", "Berget" },
                    { 89, "https://robohash.org/namlaboremaiores.png?size=100x100&set=set1", "Research and Development", "amaughan2g@youtu.be", "Agna", "Maughan" },
                    { 90, "https://robohash.org/ullamatmagni.png?size=100x100&set=set1", "Sales", "ddarrigrand2h@youku.com", "Denise", "Darrigrand" },
                    { 91, "https://robohash.org/doloremetsed.png?size=100x100&set=set1", "Research and Development", "cbuttler2i@aol.com", "Carly", "Buttler" },
                    { 92, "https://robohash.org/velofficiismaiores.png?size=100x100&set=set1", "Support", "fmciver2j@berkeley.edu", "Free", "McIver" },
                    { 93, "https://robohash.org/impeditetvoluptatibus.png?size=100x100&set=set1", "Services", "opetroulis2k@engadget.com", "Osbourn", "Petroulis" },
                    { 94, "https://robohash.org/facilisconsequaturnumquam.png?size=100x100&set=set1", "Engineering", "bthain2l@yellowpages.com", "Blaire", "Thain" },
                    { 95, "https://robohash.org/officiissuntconsequatur.png?size=100x100&set=set1", "Legal", "rboxhall2m@meetup.com", "Raymund", "Boxhall" },
                    { 96, "https://robohash.org/facilisvelitquo.png?size=100x100&set=set1", "Research and Development", "tesslemont2n@umn.edu", "Tod", "Esslemont" },
                    { 97, "https://robohash.org/itaquesitut.png?size=100x100&set=set1", "Engineering", "foppery2o@zdnet.com", "Florie", "Oppery" },
                    { 98, "https://robohash.org/nisiautitaque.png?size=100x100&set=set1", "Product Management", "pworrell2p@forbes.com", "Patrice", "Worrell" },
                    { 99, "https://robohash.org/aetsequi.png?size=100x100&set=set1", "Sales", "morth2q@psu.edu", "Mikaela", "Orth" },
                    { 100, "https://robohash.org/dolorescumqueet.png?size=100x100&set=set1", "Legal", "jdenney2r@hibu.com", "Joane", "Denney" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
