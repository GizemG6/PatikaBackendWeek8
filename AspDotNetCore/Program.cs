using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AspDotNetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // add mvc services
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // enabling the use of static files
            app.UseStaticFiles();

            // routing configuration
            app.UseRouting();

            // use of top-level route registration
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
// --------------------------------------------
// ASP.NET Core MVC Kavramları Açıklamaları
// --------------------------------------------

/*
 * 1. Controller:
 *    - Kullanıcıdan gelen istekleri (request) işleyen ve yanıt (response) döndüren sınıflardır.
 *    - Genellikle bir URL isteği bir controller ve action metoduna yönlendirilir.
 *    - Örnek: HomeController.cs dosyasında bulunan Index() metodu gibi.
 *    
 * 2. Action:
 *    - Controller sınıfındaki bir metottur ve her action bir HTTP isteğine karşılık gelir.
 *    - Örnek: public IActionResult Index() gibi.
 *    - Bu metodlar genellikle bir View döner veya veri işlemlerini gerçekleştirir.
 *
 * 3. Model:
 *    - Uygulamadaki veriyi ve bu verinin nasıl işleneceğini temsil eder.
 *    - Veritabanındaki tablolarla eşleşen sınıflar veya bir formdan gelen veriyi tutan sınıflar olabilir.
 *    - Örnek: User.cs dosyası bir kullanıcı modelidir ve kullanıcı bilgilerini içerir.
 *
 * 4. View:
 *    - Kullanıcıya gösterilecek olan HTML sayfalarıdır.
 *    - Genellikle veriyi kullanıcıya göstermek için kullanılır ve Razor (.cshtml) dosyaları ile oluşturulur.
 *    - Örnek: Index.cshtml dosyası, HomeController'dan döndürülen bir View olabilir.
 *
 * 5. Razor:
 *    - ASP.NET Core tarafından kullanılan bir şablon motorudur.
 *    - C# kodu ile HTML kodunu birleştirerek dinamik web sayfaları oluşturmayı sağlar.
 *    - Örnek: `@Model.FirstName` ifadesi Razor kullanarak model verisini HTML sayfasında gösterebilir.
 *
 * 6. Razor View:
 *    - Razor şablon motoru kullanılarak oluşturulan .cshtml uzantılı dosyalardır.
 *    - Bu dosyalar kullanıcıya HTML çıktısı döner.
 *    - Örnek: Views/Home/Index.cshtml dosyası bir Razor View'dir.
 *
 * 7. wwwroot:
 *    - Uygulamanın statik dosyalarını barındıran klasördür.
 *    - Bu klasörde CSS, JavaScript, resim dosyaları vb. bulunur.
 *    - Kullanıcılar bu dosyalara doğrudan erişebilir.
 *    - Örnek: wwwroot/css/style.css bir CSS dosyasıdır ve tarayıcı tarafından yüklenebilir.
 *
 * 8. builder.Build():
 *    - Web uygulaması yapılandırmasını tamamlar ve uygulamayı başlatılabilir hale getirir.
 *    - Tüm servislerin yapılandırılması (Dependency Injection) ve routing ayarları bu aşamaya kadar tamamlanır.
 *    - `builder.Build()` çağrısı yapıldıktan sonra servis eklenemez, çünkü artık yapı tamamlanmıştır.
 *
 * 9. app.Run():
 *    - Uygulamanın HTTP isteklerini dinlemeye ve yanıt vermeye başlamasını sağlar.
 *    - `app.Run()` çağrısı uygulamanın çalıştırılma döngüsünü başlatır ve sonlandırıcı (terminating) middleware'dir.
 *    - Bu metottan sonra herhangi bir middleware eklenemez, çünkü uygulama çalışmaya başlamıştır.
 */
