using BlazorUi.BlazorApp.Models;

namespace BlazorUi.BlazorApp.Services;

public class GalleryDbContext
{
    public List<User> Users { get; set; } = new()
    {
        new User(Guid.NewGuid(), "Chara", "123")
    };

    public List<Product> Products { get; set; } = new()
    {
        new Product(Guid.NewGuid(), "网代慎平", "为了参加青梅竹马小舟潮的葬礼，时隔2年回到故乡日都岛的17岁少年。幼时父母双亡的他在小舟家长大，所以和潮和澪的关系就像家人一般。有着能够“俯瞰”自身状况的习惯。", @"https://bkimg.cdn.bcebos.com/pic/8ad4b31c8701a18b87d6de9c9c7b100828381e305091", 100, ProductCategory.Male),
        new Product(Guid.NewGuid(), "小舟潮", "住在日都岛的17岁少女，因其有着一头从法国人父亲遗传下来的金发而令人印象深刻。为了救在海中溺水的小早川诗织而在事故中丧命。虽然喜欢青梅竹马的慎平，但是并没有表达自己的想法。", @"https://bkimg.cdn.bcebos.com/pic/7af40ad162d9f2d3572c1a3babb89d13632763d06691", 200, ProductCategory.Female),
        new Product(Guid.NewGuid(), "小舟澪", "潮的亲妹妹，高中1年级学生。擅长运动，隶属于游泳部，皮肤也因此晒黑。虽然姐姐已经去世，但面对归来的慎平却表现得很是开朗，有着坚强的一面。", @"https://bkimg.cdn.bcebos.com/pic/58ee3d6d55fbb2fb431676c64d1e37a4462308f77691", 300, ProductCategory.Female),
        new Product(Guid.NewGuid(), "南方日鹤", "穿着西装戴着眼镜、有着令人印象深刻的一头黑色长发的高个女性。因为某个原因时隔14年再次造访小岛。", @"https://bkimg.cdn.bcebos.com/pic/1b4c510fd9f9d72a605911c9d67e3f34349b023b0d91", 400, ProductCategory.Female),
        new Product(Guid.NewGuid(), "菱形窗", "17岁少年，慎平的儿时玩伴及挚友。他是日都岛唯一的医院“菱形医院”家的长子，正以成为医生为目标而努力着。正义感很强，但遗憾的是在潮发生海滩事故的时候没能阻止悲剧的发生，对此他感到很后悔。过去曾2次向澪告白，但是遭到了拒绝。", @"https://bkimg.cdn.bcebos.com/pic/902397dda144ad345982e053d2f61bf431adcaef2f91", 500, ProductCategory.Male),
        new Product(Guid.NewGuid(), "小舟艾伦", "潮和澪的父亲。出身于法国，在日都岛开了一家西餐厅“西餐厅”。对于慎平而言是在事故中失去双亲后的养父。另外，他的妻子琴子在澪出生后就去世了。", @"https://bkimg.cdn.bcebos.com/pic/43a7d933c895d143ad4b01f771a495025aafa50fa991", 600, ProductCategory.Male),
        new Product(Guid.NewGuid(), "波韬", "身穿红色和服的少女模样的神秘存在。被“影子”们称为“母亲”。", @"https://bkimg.cdn.bcebos.com/pic/a044ad345982b2b7d0a2581333f9dcef76094a362d92", 700, ProductCategory.Female),
    };

    public List<ProductGrouping> ProductGroupings { get; set; } = new();
    public List<Order> Orders { get; set; } = new();
}