﻿#region

using System;
using System.IO;

#endregion

namespace server.mysterybox
{
    internal class getBoxes : RequestHandler
    {
        protected override void HandleRequest()
        {

            //<FortuneGame id = "-3" title = "Armor of the Mad God #1" ><Description></Description><Contents>2835,2833,3105,3176,8812,3290,3279,3278,8851,8781,9017,9015,3239,3133,4103,2873,2872,3105,2762,2761,2766,2764,2759,2760,2765,9015,3276,3264,3275,3133,3177,3178,3270,1803,3138,3269,3293,3180,3274,3272</Contents><Price firstInGold="100" firstInToken="1" secondInGold="250"/><Image>http://rotmg.kabamcdn.com/MadGodArmorAlchemistRewards.png</Image><Icon></Icon><StartTime>2014-09-18 13:25:20</StartTime><EndTime>2014-09-23 13:33:00</EndTime></FortuneGame>

            using (StreamWriter wtr = new StreamWriter(Context.Response.OutputStream)) ;
        }
    } }


    