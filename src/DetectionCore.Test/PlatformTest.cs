﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace DetectionCore.Test {
    public class PlatformTest {

        [Theory]
        [InlineData(Platform.WindowsXP,"Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; Maxthon; .NET CLR 1.1.4322)")]
        [InlineData(Platform.WindowsVista,"Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; Valve Steam GameOverlay/1911; ) AppleWebKit/535.15 (KHTML, like Gecko) Chrome/18.0.989.0 Safari/535.11")]
        [InlineData(Platform.Windows7,"Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; WOW64; Trident/4.0; Avant Browser; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; CPDTDF; Avant Browser)")]
        [InlineData(Platform.Windows8,"Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.2; Trident/5.0; SlimBrowser)")]
        [InlineData(Platform.Windows81,"Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Vivaldi/1.0.73.3 Chrome/40.0.2214.82 Safari/537.36")]
        [InlineData(Platform.Windows10,"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/39.0.2171.71 Safari/537.36 Edge/12.0")]
        [InlineData(Platform.Windows,"Mozilla/5.0 (Windows; U; Win98; en-US; rv:1.8.1.20) Gecko/20081217 Firefox/2.0.0.20")]
        [InlineData(Platform.MacOs105,"Mozilla/5.0 (Macintosh; PPC Mac OS X 10.5; rv:13.0) Gecko/20120528 Firefox/13.0 TenFourFox/G5")]
        [InlineData(Platform.MacOs106,"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_6_8) AppleWebKit/535.7 (KHTML, like Gecko) Chrome/16.0.912.77 Safari/535.7")]
        [InlineData(Platform.MacOs107,"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_7_4) AppleWebKit/534.56.5 (KHTML, like Gecko) Safari/unknown")]
        [InlineData(Platform.MacOs108,"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_8_2) AppleWebKit/536.26.14 (KHTML, like Gecko) (Coda, like Safari)")]
        [InlineData(Platform.MacOs109,"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_5) AppleWebKit/601.7.8 (KHTML, like Gecko) Version/9.1.3 Safari/537.86.8")]
        [InlineData(Platform.MacOs1010,"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_5) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Safari/602.1.50")]
        [InlineData(Platform.MacOs1011,"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Safari/602.1.50")]
        [InlineData(Platform.MacOs1012,"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Safari/602.1.50")]
        [InlineData(Platform.MacOs,"Mozilla/5.0 (Macintosh; U; PPC Mac OS X; en) AppleWebKit/124 (KHTML, like Gecko) Safari/125")]
        [InlineData(Platform.ChromeOs,"Mozilla/5.0 (X11; CrOS i686 14.811.2011) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.834.0 Safari/535.1")]
        [InlineData(Platform.Ubuntu,"Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:10.0.2) Gecko/20100101 Firefox/10.0.2")]
        [InlineData(Platform.MintLinux,"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.1.1) Gecko/20090716 Linux Mint/7 (Gloria) Firefox/3.5.1")]
        [InlineData(Platform.Fedora,"Mozilla/5.0 (X11; U; Linux i686; fr; rv:1.9.0.10) Gecko/2009042708 Fedora/3.0.10-1.fc10 Firefox/3.0.10")]
        [InlineData(Platform.Gentoo,"Mozilla/5.0 (X11; U; Linux x86_64; de; rv:1.9.0.11) Gecko/2009070611 Gentoo Firefox/3.0.11")]
        [InlineData(Platform.FreeBSD,"Mozilla/5.0 (X11; U; FreeBSD amd64; en-US; rv:1.8.1.20) Gecko/20090422 Firefox/2.0.0.20 Kazehakase/0.5.4")]
        [InlineData(Platform.OpenBSD,"Mozilla/5.0 (X11; U; OpenBSD amd64; pt-BR; rv:1.9.2a1pre) Gecko/20060916 Firefox/2.0b2")]
        [InlineData(Platform.NetBSD,"Mozilla/5.0 (X11; NetBSD amd64; rv:16.0) Gecko/20121102 Firefox/16.0")]
        [InlineData(Platform.Linux,"Mozilla/5.0 (X11; U; Linux x86_64; en-us) AppleWebKit/531.2+ (KHTML, like Gecko) Version/5.0 Safari/531.2+")]
        [InlineData(Platform.Wii,"Opera/9.10 (Nintendo Wii; U; ; 1621; ja)")]
        [InlineData(Platform.PS2,"Mozilla/4.0 (PS2; PlayStation BB Navigator 1.0) NetFront/3.0")]
        [InlineData(Platform.PS3,"Mozilla/5.0 (PLAYSTATION 3; 1.00)")]
        [InlineData(Platform.PS4,"Mozilla/5.0 (PlayStation 4 1.52) AppleWebKit/536.26 (KHTML, like Gecko)")]
        [InlineData(Platform.IOS70,"Mozilla/5.0 (iPhone; CPU iPhone OS 7_0 like Mac OS X) AppleWebKit/537.51.1 (KHTML, like Gecko) GSA/5.1.42378 Mobile/11A466 Safari/9537.53")]
        [InlineData(Platform.IOS70,"Mozilla/5.0 (iPad; CPU OS 7_0 like Mac OS X) AppleWebKit/537.51.1 (KHTML, like Gecko) Version/7.0 Mobile/11A465 Safari/9537.53")]
        [InlineData(Platform.IOS71,"Mozilla/5.0 (iPhone; CPU iPhone OS 7_1_1 like Mac OS X) AppleWebKit/537.51.2 (KHTML, like Gecko) Mobile/11D201")]
        [InlineData(Platform.IOS71,"Mozilla/5.0 (iPad; CPU OS 7_1_1 like Mac OS X) AppleWebKit/537.51.2 (KHTML, like Gecko) Version/7.0 Mobile/11D201 Safari/9537.53")]
        [InlineData(Platform.IOS80,"Mozilla/5.0 (iPhone; CPU OS 8_0 like Mac OS X) AppleWebKit/600.1.3 (KHTML, like Gecko) Version/8.0 Mobile/12A4345d Safari/600.1.4")]
        [InlineData(Platform.IOS80,"Mozilla/5.0 (iPad; CPU OS 8_0 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) GSA/5.1.42378 Mobile/12A365 Safari/600.1.4")]
        [InlineData(Platform.IOS81,"Mozilla/5.0 (iPhone; CPU iPhone OS 8_1_1 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) GSA/5.1.42378 Mobile/12B435 Safari/600.1.4")]
        [InlineData(Platform.IOS81,"Mozilla/5.0 (iPad; CPU OS 8_1_3 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) CriOS/40.0.2214.69 Mobile/12B466 Safari/600.1.4")]
        [InlineData(Platform.IOS82,"Mozilla/5.0 (iPhone; CPU iPhone OS 8_2 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) Mobile/12D508")]
        [InlineData(Platform.IOS82,"Mozilla/5.0 (iPad; CPU OS 8_2 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) CriOS/42.0.2311.47 Mobile/12D508 Safari/600.1.4")]
        [InlineData(Platform.IOS83,"Mozilla/5.0 (iPhone; CPU iPhone OS 8_3 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) Mobile/12F70")]
        [InlineData(Platform.IOS83,"Mozilla/5.0 (iPad; CPU OS 8_3 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) Mobile/12F69")]
        [InlineData(Platform.IOS84,"Mozilla /5.0 (iPhone; CPU iPhone OS 8_4 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) Mobile/12H143")]
        [InlineData(Platform.IOS84,"Mozilla/5.0 (iPad; CPU OS 8_4_1 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) CriOS/45.0.2454.68 Mobile/12H321 Safari/600.1.4")]
        [InlineData(Platform.IOS90,"Mozilla /5.0 (iPhone; CPU iPhone OS 9_0 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) GSA/8.0.57838 Mobile/13A344 Safari/600.1.4")]
        [InlineData(Platform.IOS90,"Mozilla/5.0 (iPad; CPU OS 9_0 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) GSA/8.0.57838 Mobile/13A344 Safari/600.1.4")]
        [InlineData(Platform.IOS91,"Mozilla/5.0 (iPhone; CPU iPhone OS 9_1 like Mac OS X) AppleWebKit/600.1.4 (KHTML, like Gecko) GSA/14.0.119004557 Mobile/13B143 Safari/600.1.4")]
        [InlineData(Platform.IOS91,"Mozilla/5.0 (iPad; CPU OS 9_1 like Mac OS X) AppleWebKit/601.1.46 (KHTML, like Gecko) Version/9.0 Mobile/13B143 Safari/601.1")]
        [InlineData(Platform.IOS92,"Mozilla/5.0 (iPhone; CPU iPhone OS 9_2_1 like Mac OS X) AppleWebKit/601.1.46 (KHTML, like Gecko) Version/9.0 Mobile/13D20 Safari/601.1")]
        [InlineData(Platform.IOS92,"Mozilla/5.0 (iPad; CPU OS 9_2_1 like Mac OS X) AppleWebKit/601.1.46 (KHTML, like Gecko) Version/9.0 Mobile/13D15 Safari/i-filter/ios/4.50.03.03")]
        [InlineData(Platform.IOS93,"Mozilla/5.0 (iPhone; CPU iPhone OS 9_3_2 like Mac OS X) AppleWebKit/601.1 (KHTML, like Gecko) CriOS/50.0.2661.95 Mobile/13F69 Safari/601.1.46")]
        [InlineData(Platform.IOS93,"Mozilla/5.0 (iPad; CPU OS 9_3_1 like Mac OS X) AppleWebKit/601.1.46 (KHTML, like Gecko) Mobile/13E238")]
        [InlineData(Platform.IOS100,"Mozilla/5.0 (iPhone; CPU iPhone OS 10_0_1 like Mac OS X) AppleWebKit/602.1.50 (KHTML, like Gecko) Version/10.0 Mobile/14A403 Safari/602.1")]
        [InlineData(Platform.IOS,"Mozilla/5.0 (iPhone Simulator; CPU iPhone OS 5_0 like Mac OS X) AppleWebKit/534.46 (KHTML, like Gecko) Version/5.1 Mobile/9A334 Safari/7534.48.3")]
        [InlineData(Platform.Android40,"Mozilla/5.0 (Linux; U; Android 4.0.4; en-us; Outform Build/A.0.1.82_8e41c28c6cc6907c9c8753cd72987116bdc844a5) AppleWebKit/534.30 (KHTML, like Gecko) Version/4.0 Safari/534.30")]
        [InlineData(Platform.Android41,"Mozilla/5.0 (Linux; Android 4.1.1; HTC One X Build/JRO03C) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.166 Mobile Safari/535.19")]
        [InlineData(Platform.Android42,"Mozilla/5.0 (Linux;u;Android 4.2.2;zh-cn;) AppleWebKit/534.46 (KHTML,like Gecko) Version/5.1 Mobile Safari/10600.6.3 (compatible; Baiduspider/2.0; +http://www.baidu.com/search/spider.html)")]
        [InlineData(Platform.Android43,"Dalvik/1.6.0 (Linux; U; Android 4.3.1; WT19M-FI Build/JLS36I)")]
        [InlineData(Platform.Android44,"Dalvik/1.6.0 (Linux; U; Android 4.4.4; XT1080 Build/SU6-7.3)")]
        [InlineData(Platform.Android50,"Mozilla/5.0 (android; u; android 5.0; id-en) presto/2.8.89 UNTRUSTED/1.0")]
        [InlineData(Platform.Android51,"Mozilla/5.0 (Linux; Android 5.1; XT1040 Build/LPB23.13-35) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.84 Mobile Safari/537.36")]
        [InlineData(Platform.Android60,"mozilla/5.0 (Linux; Android 6.0.1; Nexus 5x build/mtc19t applewebkit/537.36 (KHTML, like Gecko) Chrome/51.0.2702.81 Mobile Safari/537.36")]
        // not found data for Android7.0
        [InlineData(Platform.Android,"Mozilla/5.0 (Android; Linux armv7l; rv:10.0) Gecko/20120123 Firefox/10.0 Fennec/10.0")]
        public void Test(string platform,string userAgent) {
            Assert.Equal(platform,userAgent.Platform());
        }
    }
}
