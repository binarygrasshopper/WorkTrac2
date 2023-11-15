using Microsoft.EntityFrameworkCore;

namespace WorkTrac.Data;

public class UserDataContext(IConfiguration configuration) : DbContext
{
    #region Member Variables
    protected readonly IConfiguration Configuration = configuration;

    #endregion
    #region ctor
    #endregion

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(Configuration.GetConnectionString("WorkTracDB"));
    }

    public DbSet<User> Users { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("User");

                modelBuilder.Entity<User>()
                    .HasData(
                        new User { Id = 1, FirstName = "Pooh", LastName = "Ivanusyev", Email = "pivanusyev0@admin.ch", Department = "Marketing", Avatar = "https://robohash.org/velestvoluptatem.png?size=100x100&set=set1" },
                        new User { Id = 2, FirstName = "Parke", LastName = "Trump", Email = "ptrump1@examiner.com", Department = "Training", Avatar = "https://robohash.org/sitsitnulla.png?size=100x100&set=set1" },
                        new User { Id = 3, FirstName = "Alvina", LastName = "Gyppes", Email = "agyppes2@cyberchimps.com", Department = "Sales", Avatar = "https://robohash.org/rationequoarchitecto.png?size=100x100&set=set1" },
                        new User { Id = 4, FirstName = "Ellissa", LastName = "Vasyutin", Email = "evasyutin3@tamu.edu", Department = "Product Management", Avatar = "https://robohash.org/blanditiisfugiatipsam.png?size=100x100&set=set1" },
                        new User { Id = 5, FirstName = "Cordelia", LastName = "Davy", Email = "cdavy4@chicagotribune.com", Department = "Services", Avatar = "https://robohash.org/aliquidsuntinventore.png?size=100x100&set=set1" },
                        new User { Id = 6, FirstName = "Aristotle", LastName = "Glide", Email = "aglide5@furl.net", Department = "Accounting", Avatar = "https://robohash.org/illoinciduntatque.png?size=100x100&set=set1" },
                        new User { Id = 7, FirstName = "Elisabetta", LastName = "Arran", Email = "earran6@rambler.ru", Department = "Human Resources", Avatar = "https://robohash.org/odioquinemo.png?size=100x100&set=set1" },
                        new User { Id = 8, FirstName = "Lesley", LastName = "Buncom", Email = "lbuncom7@xing.com", Department = "Research and Development", Avatar = "https://robohash.org/utautmolestiae.png?size=100x100&set=set1" },
                        new User { Id = 9, FirstName = "Tedd", LastName = "Caselick", Email = "tcaselick8@amazon.com", Department = "Services", Avatar = "https://robohash.org/debitisetcorporis.png?size=100x100&set=set1" },
                        new User { Id = 10, FirstName = "Orella", LastName = "Coggles", Email = "ocoggles9@time.com", Department = "Support", Avatar = "https://robohash.org/utminimafugit.png?size=100x100&set=set1" },
                        new User { Id = 11, FirstName = "Zabrina", LastName = "Mallion", Email = "zmalliona@paypal.com", Department = "Support", Avatar = "https://robohash.org/estautmagnam.png?size=100x100&set=set1" },
                        new User { Id = 12, FirstName = "Kate", LastName = "Darree", Email = "kdarreeb@yellowpages.com", Department = "Legal", Avatar = "https://robohash.org/voluptatessolutaipsa.png?size=100x100&set=set1" },
                        new User { Id = 13, FirstName = "Ringo", LastName = "Danilovich", Email = "rdanilovichc@forbes.com", Department = "Marketing", Avatar = "https://robohash.org/quiullamblanditiis.png?size=100x100&set=set1" },
                        new User { Id = 14, FirstName = "Ina", LastName = "McSporrin", Email = "imcsporrind@pagesperso-orange.fr", Department = "Support", Avatar = "https://robohash.org/autaenim.png?size=100x100&set=set1" },
                        new User { Id = 15, FirstName = "Ellsworth", LastName = "Gulleford", Email = "egulleforde@zimbio.com", Department = "Marketing", Avatar = "https://robohash.org/corruptiquidemconsectetur.png?size=100x100&set=set1" },
                        new User { Id = 16, FirstName = "Say", LastName = "Rivel", Email = "srivelf@google.com.hk", Department = "Marketing", Avatar = "https://robohash.org/voluptasullamdebitis.png?size=100x100&set=set1" },
                        new User { Id = 17, FirstName = "Samuel", LastName = "Nowland", Email = "snowlandg@ask.com", Department = "Marketing", Avatar = "https://robohash.org/consequatursitmollitia.png?size=100x100&set=set1" },
                        new User { Id = 18, FirstName = "Katya", LastName = "Martignon", Email = "kmartignonh@dmoz.org", Department = "Product Management", Avatar = "https://robohash.org/architectonesciuntmagni.png?size=100x100&set=set1" },
                        new User { Id = 19, FirstName = "Leshia", LastName = "Lenormand", Email = "llenormandi@wiley.com", Department = "Services", Avatar = "https://robohash.org/velsedmolestiae.png?size=100x100&set=set1" },
                        new User { Id = 20, FirstName = "Ursuline", LastName = "Welsh", Email = "uwelshj@mapquest.com", Department = "Services", Avatar = "https://robohash.org/perspiciatissuntdolorum.png?size=100x100&set=set1" },
                        new User { Id = 21, FirstName = "Olympia", LastName = "Chaucer", Email = "ochaucerk@cafepress.com", Department = "Human Resources", Avatar = "https://robohash.org/doloreducimusin.png?size=100x100&set=set1" },
                        new User { Id = 22, FirstName = "Kerri", LastName = "Billingsley", Email = "kbillingsleyl@free.fr", Department = "Accounting", Avatar = "https://robohash.org/quiipsalaboriosam.png?size=100x100&set=set1" },
                        new User { Id = 23, FirstName = "Brand", LastName = "Yaldren", Email = "byaldrenm@census.gov", Department = "Sales", Avatar = "https://robohash.org/repudiandaeetnostrum.png?size=100x100&set=set1" },
                        new User { Id = 24, FirstName = "Munroe", LastName = "Bletcher", Email = "mbletchern@unesco.org", Department = "Services", Avatar = "https://robohash.org/nonsitest.png?size=100x100&set=set1" },
                        new User { Id = 25, FirstName = "Moina", LastName = "Betjes", Email = "mbetjeso@yellowpages.com", Department = "Engineering", Avatar = "https://robohash.org/accusamusveniameligendi.png?size=100x100&set=set1" },
                        new User { Id = 26, FirstName = "Riva", LastName = "Yukhnevich", Email = "ryukhnevichp@moonfruit.com", Department = "Engineering", Avatar = "https://robohash.org/possimusvoluptatemodit.png?size=100x100&set=set1" },
                        new User { Id = 27, FirstName = "Alard", LastName = "McAteer", Email = "amcateerq@usgs.gov", Department = "Services", Avatar = "https://robohash.org/quoquianon.png?size=100x100&set=set1" },
                        new User { Id = 28, FirstName = "Sadella", LastName = "Maddin", Email = "smaddinr@wired.com", Department = "Human Resources", Avatar = "https://robohash.org/quodenimnisi.png?size=100x100&set=set1" },
                        new User { Id = 29, FirstName = "Steven", LastName = "Brusle", Email = "sbrusles@senate.gov", Department = "Services", Avatar = "https://robohash.org/sintveritatisminus.png?size=100x100&set=set1" },
                        new User { Id = 30, FirstName = "Arv", LastName = "Leishman", Email = "aleishmant@yellowbook.com", Department = "Support", Avatar = "https://robohash.org/accusamusvoluptasillo.png?size=100x100&set=set1" },
                        new User { Id = 31, FirstName = "Reinaldo", LastName = "Plaschke", Email = "rplaschkeu@4shared.com", Department = "Training", Avatar = "https://robohash.org/eligendinonquia.png?size=100x100&set=set1" },
                        new User { Id = 32, FirstName = "Iorgos", LastName = "Stilly", Email = "istillyv@sbwire.com", Department = "Legal", Avatar = "https://robohash.org/atquealiasdoloremque.png?size=100x100&set=set1" },
                        new User { Id = 33, FirstName = "Terrell", LastName = "Ricciardiello", Email = "tricciardiellow@bbc.co.uk", Department = "Engineering", Avatar = "https://robohash.org/illumofficianam.png?size=100x100&set=set1" },
                        new User { Id = 34, FirstName = "Sybille", LastName = "Casillis", Email = "scasillisx@oaic.gov.au", Department = "Engineering", Avatar = "https://robohash.org/sitetlabore.png?size=100x100&set=set1" },
                        new User { Id = 35, FirstName = "Jobye", LastName = "Goodding", Email = "jgooddingy@dropbox.com", Department = "Product Management", Avatar = "https://robohash.org/nullavelitconsequatur.png?size=100x100&set=set1" },
                        new User { Id = 36, FirstName = "Cleve", LastName = "Winfield", Email = "cwinfieldz@ted.com", Department = "Product Management", Avatar = "https://robohash.org/maximeutimpedit.png?size=100x100&set=set1" },
                        new User { Id = 37, FirstName = "Ernst", LastName = "Dotson", Email = "edotson10@alibaba.com", Department = "Research and Development", Avatar = "https://robohash.org/eosetmolestiae.png?size=100x100&set=set1" },
                        new User { Id = 38, FirstName = "Denny", LastName = "Van Salzberger", Email = "dvansalzberger11@php.net", Department = "Support", Avatar = "https://robohash.org/verocumqueest.png?size=100x100&set=set1" },
                        new User { Id = 39, FirstName = "Benn", LastName = "Petru", Email = "bpetru12@merriam-webster.com", Department = "Legal", Avatar = "https://robohash.org/iureaveritatis.png?size=100x100&set=set1" },
                        new User { Id = 40, FirstName = "Helen", LastName = "Dreigher", Email = "hdreigher13@businessweek.com", Department = "Training", Avatar = "https://robohash.org/quidemmolestiaelaborum.png?size=100x100&set=set1" },
                        new User { Id = 41, FirstName = "Cosimo", LastName = "Aubrey", Email = "caubrey14@businesswire.com", Department = "Engineering", Avatar = "https://robohash.org/etperferendisquis.png?size=100x100&set=set1" },
                        new User { Id = 42, FirstName = "Barry", LastName = "Arran", Email = "barran15@unblog.fr", Department = "Legal", Avatar = "https://robohash.org/temporibuseaid.png?size=100x100&set=set1" },
                        new User { Id = 43, FirstName = "Sabra", LastName = "Hatchette", Email = "shatchette16@cbsnews.com", Department = "Services", Avatar = "https://robohash.org/quisitomnis.png?size=100x100&set=set1" },
                        new User { Id = 44, FirstName = "Vinnie", LastName = "Sabathe", Email = "vsabathe17@prnewswire.com", Department = "Training", Avatar = "https://robohash.org/errordoloremquetempora.png?size=100x100&set=set1" },
                        new User { Id = 45, FirstName = "Townsend", LastName = "Granleese", Email = "tgranleese18@wufoo.com", Department = "Accounting", Avatar = "https://robohash.org/sintevenietvel.png?size=100x100&set=set1" },
                        new User { Id = 46, FirstName = "Aila", LastName = "Islip", Email = "aislip19@abc.net.au", Department = "Sales", Avatar = "https://robohash.org/solutaidsunt.png?size=100x100&set=set1" },
                        new User { Id = 47, FirstName = "Dierdre", LastName = "Ferryn", Email = "dferryn1a@mashable.com", Department = "Training", Avatar = "https://robohash.org/magnamassumendaautem.png?size=100x100&set=set1" },
                        new User { Id = 48, FirstName = "Sharyl", LastName = "Blackmoor", Email = "sblackmoor1b@joomla.org", Department = "Business Development", Avatar = "https://robohash.org/eumquisporro.png?size=100x100&set=set1" },
                        new User { Id = 49, FirstName = "Lisetta", LastName = "Meriel", Email = "lmeriel1c@soundcloud.com", Department = "Research and Development", Avatar = "https://robohash.org/sapienteipsaconsequatur.png?size=100x100&set=set1" },
                        new User { Id = 50, FirstName = "Shelby", LastName = "Eble", Email = "seble1d@slashdot.org", Department = "Sales", Avatar = "https://robohash.org/utsuntqui.png?size=100x100&set=set1" },
                        new User { Id = 51, FirstName = "Shela", LastName = "Nisen", Email = "snisen1e@github.io", Department = "Services", Avatar = "https://robohash.org/suscipitquamquo.png?size=100x100&set=set1" },
                        new User { Id = 52, FirstName = "Cristi", LastName = "Nelius", Email = "cnelius1f@cnet.com", Department = "Business Development", Avatar = "https://robohash.org/consecteturquiexpedita.png?size=100x100&set=set1" },
                        new User { Id = 53, FirstName = "Leticia", LastName = "Davidowich", Email = "ldavidowich1g@walmart.com", Department = "Training", Avatar = "https://robohash.org/accusamusautemlaborum.png?size=100x100&set=set1" },
                        new User { Id = 54, FirstName = "Joete", LastName = "Ionnidis", Email = "jionnidis1h@cnbc.com", Department = "Engineering", Avatar = "https://robohash.org/quidemsuntmaiores.png?size=100x100&set=set1" },
                        new User { Id = 55, FirstName = "Georgeta", LastName = "Gayle", Email = "ggayle1i@issuu.com", Department = "Research and Development", Avatar = "https://robohash.org/enimestaut.png?size=100x100&set=set1" },
                        new User { Id = 56, FirstName = "Nicolais", LastName = "Percy", Email = "npercy1j@fotki.com", Department = "Product Management", Avatar = "https://robohash.org/omnisetdistinctio.png?size=100x100&set=set1" },
                        new User { Id = 57, FirstName = "Joellyn", LastName = "Loughton", Email = "jloughton1k@digg.com", Department = "Accounting", Avatar = "https://robohash.org/nihilvoluptatumab.png?size=100x100&set=set1" },
                        new User { Id = 58, FirstName = "Davie", LastName = "Bretton", Email = "dbretton1l@omniture.com", Department = "Business Development", Avatar = "https://robohash.org/nequeabquidem.png?size=100x100&set=set1" },
                        new User { Id = 59, FirstName = "Saree", LastName = "D'Abbot-Doyle", Email = "sdabbotdoyle1m@arstechnica.com", Department = "Sales", Avatar = "https://robohash.org/autaliasquo.png?size=100x100&set=set1" },
                        new User { Id = 60, FirstName = "Hobie", LastName = "Gloves", Email = "hgloves1n@sun.com", Department = "Research and Development", Avatar = "https://robohash.org/etveniameum.png?size=100x100&set=set1" },
                        new User { Id = 61, FirstName = "Vanessa", LastName = "Weerdenburg", Email = "vweerdenburg1o@arstechnica.com", Department = "Support", Avatar = "https://robohash.org/itaqueenimtemporibus.png?size=100x100&set=set1" },
                        new User { Id = 62, FirstName = "Grove", LastName = "Ledwitch", Email = "gledwitch1p@twitter.com", Department = "Accounting", Avatar = "https://robohash.org/veniamautautem.png?size=100x100&set=set1" },
                        new User { Id = 63, FirstName = "Gary", LastName = "Poe", Email = "gpoe1q@cafepress.com", Department = "Product Management", Avatar = "https://robohash.org/quiofficiaunde.png?size=100x100&set=set1" },
                        new User { Id = 64, FirstName = "Yolane", LastName = "Dussy", Email = "ydussy1r@home.pl", Department = "Engineering", Avatar = "https://robohash.org/officiisnullavel.png?size=100x100&set=set1" },
                        new User { Id = 65, FirstName = "Mirna", LastName = "McEntegart", Email = "mmcentegart1s@spiegel.de", Department = "Services", Avatar = "https://robohash.org/estaliquidmagnam.png?size=100x100&set=set1" },
                        new User { Id = 66, FirstName = "Sarene", LastName = "Pickless", Email = "spickless1t@merriam-webster.com", Department = "Research and Development", Avatar = "https://robohash.org/voluptassuscipitut.png?size=100x100&set=set1" },
                        new User { Id = 67, FirstName = "Ashley", LastName = "Matyugin", Email = "amatyugin1u@phpbb.com", Department = "Accounting", Avatar = "https://robohash.org/quisrepudiandaenisi.png?size=100x100&set=set1" },
                        new User { Id = 68, FirstName = "Ursa", LastName = "Mintoft", Email = "umintoft1v@joomla.org", Department = "Engineering", Avatar = "https://robohash.org/utitaqueenim.png?size=100x100&set=set1" },
                        new User { Id = 69, FirstName = "Valera", LastName = "Rockcliff", Email = "vrockcliff1w@umn.edu", Department = "Marketing", Avatar = "https://robohash.org/isteetautem.png?size=100x100&set=set1" },
                        new User { Id = 70, FirstName = "Brad", LastName = "Bohea", Email = "bbohea1x@liveinternet.ru", Department = "Product Management", Avatar = "https://robohash.org/inquiomnis.png?size=100x100&set=set1" },
                        new User { Id = 71, FirstName = "Star", LastName = "Mathissen", Email = "smathissen1y@soup.io", Department = "Sales", Avatar = "https://robohash.org/aspernaturveroea.png?size=100x100&set=set1" },
                        new User { Id = 72, FirstName = "Heather", LastName = "Youd", Email = "hyoud1z@berkeley.edu", Department = "Accounting", Avatar = "https://robohash.org/optiodelenitisoluta.png?size=100x100&set=set1" },
                        new User { Id = 73, FirstName = "Meredith", LastName = "Craythorne", Email = "mcraythorne20@paginegialle.it", Department = "Training", Avatar = "https://robohash.org/rerumvoluptasminima.png?size=100x100&set=set1" },
                        new User { Id = 74, FirstName = "Austin", LastName = "Kenion", Email = "akenion21@360.cn", Department = "Services", Avatar = "https://robohash.org/corruptivoluptatemrepudiandae.png?size=100x100&set=set1" },
                        new User { Id = 75, FirstName = "Cosette", LastName = "Bradneck", Email = "cbradneck22@psu.edu", Department = "Marketing", Avatar = "https://robohash.org/corporisearumdolor.png?size=100x100&set=set1" },
                        new User { Id = 76, FirstName = "Terra", LastName = "Trimble", Email = "ttrimble23@miitbeian.gov.cn", Department = "Product Management", Avatar = "https://robohash.org/distinctiofugiataliquid.png?size=100x100&set=set1" },
                        new User { Id = 77, FirstName = "Roseanna", LastName = "Caras", Email = "rcaras24@ow.ly", Department = "Support", Avatar = "https://robohash.org/idveritatisvel.png?size=100x100&set=set1" },
                        new User { Id = 78, FirstName = "Johna", LastName = "Michelle", Email = "jmichelle25@soup.io", Department = "Product Management", Avatar = "https://robohash.org/nihilrepellatprovident.png?size=100x100&set=set1" },
                        new User { Id = 79, FirstName = "Harland", LastName = "Lindholm", Email = "hlindholm26@ft.com", Department = "Legal", Avatar = "https://robohash.org/aliquamiustooccaecati.png?size=100x100&set=set1" },
                        new User { Id = 80, FirstName = "Allayne", LastName = "Concannon", Email = "aconcannon27@xinhuanet.com", Department = "Services", Avatar = "https://robohash.org/iustoetlibero.png?size=100x100&set=set1" },
                        new User { Id = 81, FirstName = "Lenna", LastName = "Doerr", Email = "ldoerr28@marketwatch.com", Department = "Support", Avatar = "https://robohash.org/eumomnisdolor.png?size=100x100&set=set1" },
                        new User { Id = 82, FirstName = "Edan", LastName = "Jenckes", Email = "ejenckes29@skype.com", Department = "Marketing", Avatar = "https://robohash.org/abquosea.png?size=100x100&set=set1" },
                        new User { Id = 83, FirstName = "Luciano", LastName = "Paffett", Email = "lpaffett2a@toplist.cz", Department = "Product Management", Avatar = "https://robohash.org/estadipisciquos.png?size=100x100&set=set1" },
                        new User { Id = 84, FirstName = "Hazlett", LastName = "Gatteridge", Email = "hgatteridge2b@geocities.com", Department = "Marketing", Avatar = "https://robohash.org/idplaceatnumquam.png?size=100x100&set=set1" },
                        new User { Id = 85, FirstName = "Merrili", LastName = "Lauga", Email = "mlauga2c@cocolog-nifty.com", Department = "Business Development", Avatar = "https://robohash.org/autemestet.png?size=100x100&set=set1" },
                        new User { Id = 86, FirstName = "Kris", LastName = "Beeho", Email = "kbeeho2d@github.com", Department = "Sales", Avatar = "https://robohash.org/etvoluptatumillo.png?size=100x100&set=set1" },
                        new User { Id = 87, FirstName = "Carolyne", LastName = "Petrescu", Email = "cpetrescu2e@nps.gov", Department = "Services", Avatar = "https://robohash.org/temporibusnatuset.png?size=100x100&set=set1" },
                        new User { Id = 88, FirstName = "Edith", LastName = "Berget", Email = "eberget2f@163.com", Department = "Product Management", Avatar = "https://robohash.org/autemquiavoluptas.png?size=100x100&set=set1" },
                        new User { Id = 89, FirstName = "Agna", LastName = "Maughan", Email = "amaughan2g@youtu.be", Department = "Research and Development", Avatar = "https://robohash.org/namlaboremaiores.png?size=100x100&set=set1" },
                        new User { Id = 90, FirstName = "Denise", LastName = "Darrigrand", Email = "ddarrigrand2h@youku.com", Department = "Sales", Avatar = "https://robohash.org/ullamatmagni.png?size=100x100&set=set1" },
                        new User { Id = 91, FirstName = "Carly", LastName = "Buttler", Email = "cbuttler2i@aol.com", Department = "Research and Development", Avatar = "https://robohash.org/doloremetsed.png?size=100x100&set=set1" },
                        new User { Id = 92, FirstName = "Free", LastName = "McIver", Email = "fmciver2j@berkeley.edu", Department = "Support", Avatar = "https://robohash.org/velofficiismaiores.png?size=100x100&set=set1" },
                        new User { Id = 93, FirstName = "Osbourn", LastName = "Petroulis", Email = "opetroulis2k@engadget.com", Department = "Services", Avatar = "https://robohash.org/impeditetvoluptatibus.png?size=100x100&set=set1" },
                        new User { Id = 94, FirstName = "Blaire", LastName = "Thain", Email = "bthain2l@yellowpages.com", Department = "Engineering", Avatar = "https://robohash.org/facilisconsequaturnumquam.png?size=100x100&set=set1" },
                        new User { Id = 95, FirstName = "Raymund", LastName = "Boxhall", Email = "rboxhall2m@meetup.com", Department = "Legal", Avatar = "https://robohash.org/officiissuntconsequatur.png?size=100x100&set=set1" },
                        new User { Id = 96, FirstName = "Tod", LastName = "Esslemont", Email = "tesslemont2n@umn.edu", Department = "Research and Development", Avatar = "https://robohash.org/facilisvelitquo.png?size=100x100&set=set1" },
                        new User { Id = 97, FirstName = "Florie", LastName = "Oppery", Email = "foppery2o@zdnet.com", Department = "Engineering", Avatar = "https://robohash.org/itaquesitut.png?size=100x100&set=set1" },
                        new User { Id = 98, FirstName = "Patrice", LastName = "Worrell", Email = "pworrell2p@forbes.com", Department = "Product Management", Avatar = "https://robohash.org/nisiautitaque.png?size=100x100&set=set1" },
                        new User { Id = 99, FirstName = "Mikaela", LastName = "Orth", Email = "morth2q@psu.edu", Department = "Sales", Avatar = "https://robohash.org/aetsequi.png?size=100x100&set=set1" },
                        new User { Id = 100, FirstName = "Joane", LastName = "Denney", Email = "jdenney2r@hibu.com", Department = "Legal", Avatar = "https://robohash.org/dolorescumqueet.png?size=100x100&set=set1" }
                    );
        }
}
