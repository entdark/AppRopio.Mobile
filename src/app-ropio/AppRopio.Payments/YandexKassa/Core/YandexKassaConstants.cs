﻿using System;
namespace AppRopio.Payments.YandexKassa.Core
{
    public class YandexKassaConstants
    {
        public const string CONFIG_NAME = "YandexKassa.json";

        public const string RESX_NAME = "YandexKassa";

#if DEBUG
        public const string PAY_URL = "https://demomoney.yandex.ru/eshop.xml";
#else
        public const string PAY_URL = "https://money.yandex.ru/eshop.xml";
#endif

    }
}
