namespace CSharpLeetCode.Tests
{
    [TestFixture]
    public class UnitTest2408_DesignSQL
    {
        [Test]
        public void Test_DesignSQL_FirstLeetCodeCase()
        {
            var sql = new SQL(new[] {"one", "two", "three"}, new[] {2,3,1});
            sql.InsertRow("two", new[] {"first", "second", "third"});
            var cell = sql.SelectCell("two", 1, 3);
            sql.InsertRow("two", new [] {"fourth", "fifth", "sixth"});
            sql.DeleteRow("two", 1);
            
            var secondCell = sql.SelectCell("two", 2, 2);
            
            Assert.Multiple(() =>
            {
                Assert.That(cell, Is.EqualTo("third"));

                Assert.That(secondCell, Is.EqualTo("fifth"));
            });
        }

        [Test]
        public void Test_DesignSQL_SecondLeetCodeCase()
        {
            var sql = new SQL(
                new[]
                {
                    "ezvmcvo", "hpl", "rzimsnl", "hqkdiegyww", "xh", "yzdqbsbpf", "bevrjg", "fjl", "blmii",
                    "lhmokfpsrzqsp", "vaagbakkk", "dkamxrijel"
                }, new[] {5, 21, 89, 46, 76, 19, 8, 4, 94, 60, 55, 35});
            sql.InsertRow("vaagbakkk",new[] {"gdf","isqtdrehthloyffwd","iaf","lljmps","ioqpqmy","wwtpogfmvhl","jeazwtgutluusobqab","uvcb","eo","afzkxpvl","xttcampjwu","bosdjzkyheuh","zgnjcyyptsz","giitirdcgjscjw","zf","ylebtgcuagruqnrne","kfiyopbmpptbgsqonehq","tctypfwp","gceohlgwppmturjoqdtr","sdyyenklgfboykrm","qkezxnj","apzsbpgd","zkujjb","stx","uqsnz","izografitvodbuvvyk","pd","pageu","eunrb","bhnskbjqgwbytz","vmxwyzysaysty","aegdtqhlujcxxqxgirql","ch","evwhyqqim","yfkbpvxokfn","qwuth","d","pvumlgmmakjofls","lyssuu","cyxoemph","itwdvcr","vpbaagarp","ll","dvponkezfqps","tt","rokmwfbhysswbtkefluf","lajl","fxeith","robgiawvabukzifdwicw","tfsqsqvglqqodep","hvqplfmmwjcyru","cys","nmdiknoezyesvms","ytjruvumiscm","rps"});
            var firstCell = sql.SelectCell("vaagbakkk", 1, 48);
            var secondCell = sql.SelectCell("vaagbakkk", 1, 16);
            var thirdCell = sql.SelectCell("vaagbakkk", 1, 44);
            var fourthCell = sql.SelectCell("vaagbakkk",1,8);
            sql.InsertRow("blmii",new[] {"tux","ewkkyuhmjuupncoiwyh","mhmplnagrbgk","pjskjjxnglm","jepicmzzjmejkmxue","wzmr","uhdesaxeshobethupdds","xpybaqoynkvpcufq","avtiiqnsfmtnlbxvtho","hfwzsbmtl","zigntfymh","egdgslxebsffamnmwkb","nhryuvau","e","nlfwyuzptvhrp","tycl","hsd","emksgserntne","ekvgtjsoekw","bghfk","wgvumxjvpzgorpha","drkqx","ulhkdtzdal","embmftyi","snh","aorfs","v","dtgmjiuusutsdrxubl","hgkkvsiffdngwhcy","ilabawdbasdycqezmnwi","mkexpxewphghz","cqs","vyybd","huywdcbnfqwdzirfpqm","mgrjbhrjjsqeifjxj","cgejphkt","fwplcv","krubehjpd","owuugwkzabanxncak","pjhhglxecu","cound","kniazvolodsx","cwnvwsspqkokzycm","jiv","xsaxsbiixeesqctt","srtvgert","hru","xbprlnypb","ekcewyyidf","hcisegofxkwxndhcqs","abaqs","cxcuq","i","jjajz","rnwkxvnlmxvk","dusfnpwrehcm","dkrapsfxzj","qqvsvipuuiowg","pzsncqxdjkinf","qxutrxg","isdqgbmvlyen","rcvueqckc","qsseppnajlyfqinxluzs","g","ruaptmeukooi","bfadigxmffkcoedjlj","dljfefmmgvcfh","ahbebx","ye","ipiqzfmeledxhktulj","iudaets","hbchyrmtuscjzene","lvhwgmmhzv","otrhmvv","zsvmx","gijimecoaqatedddvx","unzikry","gnbapvcfrpsqemt","szvfcgndqbpkgllpey","kzd","ueonx","rdasfaqbipmmp","cythqindlkcwgouyvdv","mib","v","rwuhd","wqceihbjrjbyvdoupw","p","pdrqiqqbloywiccxes","fkrhkgwg","ugxszvpeaeyghiqllgt","bubytvsrwqierqq","rbdebixthjjrmkf","bhdgupmeqfjla"});
            sql.DeleteRow("vaagbakkk", 1);
            
            var fifthCell = sql.SelectCell("blmii",1,35);
            
            Assert.Multiple(() =>
            {
                Assert.That(firstCell, Is.EqualTo("fxeith"));
                Assert.That(secondCell, Is.EqualTo("ylebtgcuagruqnrne"));
                Assert.That(thirdCell, Is.EqualTo("dvponkezfqps"));
                Assert.That(fourthCell, Is.EqualTo("uvcb"));
                Assert.That(fifthCell, Is.EqualTo("mgrjbhrjjsqeifjxj"));
            });
        }
    }
}