# 一、專案建立
# 二、環境介紹
- prgram.cs
- startup.cs
- properties
- controllers
- views
- Models
- appsettings.json
# 三、EntityFramework
- 使用CommandLine建立Entity
# 四、startup 設定
- 注入DB Entity
- 注入NewtonSoftJSON
- 
# 五、服務注入 
 - 服務生命週期 
   - Transient
        - 每次注入時，都重新 new 一個新的實體。
   - Scoped
        - 每個 Request 都重新 new 一個新的實體。
   - Singleton
        - 程式啟動後會 new 一個實體。也就是運行期間只會有一個實體。
   - HttpClient
     - 執行http request和response的實體
   - HostService 
     - 背景服務的實體
 - 建構子注入
 - Razor注入Service
 - 在Area注入Service

 
# 六、middleware
    - servicefilter
# 七、ViewComponent



# 參考文件
- https://docs.microsoft.com/zh-tw/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.2#service-lifetimes

- https://joonasw.net/view/aspnet-core-di-deep-dive
- https://dotblogs.com.tw/armycoding/2018/10/19/013412
- https://blog.johnwu.cc/article/ironman-day04-asp-net-core-dependency-injection.html