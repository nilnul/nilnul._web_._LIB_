using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.web.http.restful
{
	/*
	 作者：覃超
链接：https://www.zhihu.com/question/27785028/answer/48096396
来源：知乎
著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。


Server的API如何设计才满足RESTful要求?
首先是简洁版里面的那几点。外加一些附带的 best practices：
1. URL root:

https://example.org/api/v1/*
https://api.example.com/v1/*
2. API versioning:
可以放在URL里面，也可以用HTTP的header：

/api/v1/

3. URI使用名词而不是动词，且推荐用复数。
BAD

/getProducts
/listOrders
/retrieveClientByOrder?orderId=1
GOOD

GET /products : will return the list of all products
POST /products : will add a product to the collection
GET /products/4 : will retrieve product #4
PATCH/PUT /products/4 : will update product #4
4. 保证 HEAD 和 GET 方法是安全的，不会对资源状态有所改变（污染）。比如严格杜绝如下情况：

GET /deleteProduct?id=1

5. 资源的地址推荐用嵌套结构。比如：

GET /friends/10375923/profile
UPDATE /profile/primaryAddress/city

6. 警惕返回结果的大小。如果过大，及时进行分页（pagination）或者加入限制（limit）。HTTP协议支持分页（Pagination）操作，在Header中使用 Link 即可。


7. 使用正确的HTTP Status Code表示访问状态：HTTP/1.1: Status Code Definitions
8. 在返回结果用明确易懂的文本（String。注意返回的错误是要给人看的，避免用 1001 这种错误信息），而且适当地加入注释。
9. 关于安全：自己的接口就用https，加上一个key做一次hash放在最后即可。考虑到国情，HTTPS在无线网络里不稳定，可以使用Application Level的加密手段把整个HTTP的payload加密。有兴趣的朋友可以用手机连上电脑的共享Wi-Fi，然后用Charles监听微信的网络请求（发照片或者刷朋友圈）。
如果是平台的API，可以用成熟但是复杂的OAuth2，新浪微博这篇：授权机制说明

各端的具体实现
如上面的图所示，Server统一提供一套RESTful API，web+ios+android作为同等公民调用API。各端发展到现在，都有一套比较成熟的框架来帮开发者事半功倍。

-- Server --
推荐： Spring MVC 或者 Jersey 或者 Play Framework
教程：
Getting Started · Building a RESTful Web Service

-- Android --
推荐： RetroFit ( Retrofit ) 或者 Volley ( mcxiaoke/android-volley · GitHub Google官方的被block，就不贴了 ) 
教程：
Retrofit โ Getting Started and Create an Android Client
快速Android开发系列网络篇之Retrofit

-- iOS --
推荐：RestKit ( RestKit/RestKit · GitHub )
教程：
Developing RESTful iOS Apps with RestKit

-- Web --
推荐随便搞！可以用重量级的AngularJS，也可以用轻量级 Backbone + jQuery 等。
教程：http://blog.javachen.com/2015/01/06/build-app-with-spring-boot-and-gradle/

参考：
[1]: Some REST best practices
[2]: GitHub API v3
[3]: tlhunter/consumer-centric-api-design · GitHub
最后附带一个彩蛋：
Facebook台球表演: 台球1—在线播放
		 */
	interface ConventionI
	{
	}
}
