using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Requests;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using static System.Net.Mime.MediaTypeNames;

namespace TelegramTestProject4
{
    class Program
    {
        private static string token { get; set; } = "5935819179:AAFyo_voDdaX8cDsKhveonh6ktl9qDrlpsY";
        private static TelegramBotClient client;
        static void Main(string[] args)
        {
            client = new TelegramBotClient(token);
            client.StartReceiving();
            client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            client.StopReceiving();

        }

        private static async void OnMessageHandler(object? sender, MessageEventArgs e)
        {
            var msg = e.Message;
            if (msg.Text !=null)
            {
                Console.WriteLine($"Надiсланi повiдомлення: {msg.Text}");
                {
                    if (msg.Text == "Головна сторінка")
                    {
                        var inlineKeyboard = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(new[]
                            {
                                new [] // first row
                                {
                                    InlineKeyboardButton.WithUrl("Деканат факультету", "https://knute.edu.ua/blog/read/?pid=9"),
                                    InlineKeyboardButton.WithCallbackData("Кафедри факультету"),
                                    InlineKeyboardButton.WithUrl("Студентське життя", "https://knute.edu.ua/blog/read/?pid=45110"),
                                },
                                new [] // second row
                                {
                                    InlineKeyboardButton.WithUrl("Освітні програми", "https://knute.edu.ua/blog/read/?pid=29414&uk"),
                                    InlineKeyboardButton.WithUrl("Вступнику", "https://knute.edu.ua/blog/read/?pid=44883&uk")
                                }
                            });
                        //await client.SendPhotoAsync(msg.Chat.Id, photo: "https://knute.edu.ua/file/NDAxMw==/0a1494fb645f769b6d6e187d96947d21.png");
                        await client.SendTextMessageAsync(msg.Chat.Id, "Навчання на факультеті проводиться за новітніми навчальними програмами курсів, що викладаються на бакалаврських та магістерських рівнях, які кожного року переглядаються та удосконалюються. Заняття проходять в комп'ютерних класах та лабораторіях, обладнаних сучасною обчислювальною та організаційною технікою. Фахівці з ІТ-компаній запрошуються до викладання спеціалізованих курсів, проводять відкриті лекції та тренінги. Випускники факультету працюють у провідних компаніях України та світу.", replyMarkup: inlineKeyboard, parseMode: ParseMode.Markdown);
                    }
                    if (msg.Text == "Кафедри")
                    {
                        var inlineKeyboard = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(new[]
                            {
                                new [] // first row
                                {
                                    InlineKeyboardButton.WithCallbackData("ЦЕ та СА"),
                                    InlineKeyboardButton.WithCallbackData("ІПЗ та КБ"),
                                },
                                new [] // second row
                                {
                                    InlineKeyboardButton.WithCallbackData("КН та ІС"),
                                    InlineKeyboardButton.WithCallbackData("В та ПМ"),
                                }
                            });
                        await client.SendTextMessageAsync(msg.Chat.Id, "До складу факультету входять 4 кафедри:", replyMarkup: inlineKeyboard, parseMode: ParseMode.Markdown);
                    }
                    /*if (msg.Text == "Реєстр стипендіатів") не працює через помилки із символами на InlineKeyboardButton
                    {
                        var inlineKeyboard = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(new[]
                            {
                                new [] // first row
                                {
                                    InlineKeyboardButton.WithUrl("1К ОС МБ", "https://knute.edu.ua/file/NDAxMw==/5007df2e83f0c7e772b908c50cae7d8d.pdf"),
                                    InlineKeyboardButton.WithUrl("1К ОС Б", "https://knute.edu.ua/file/NDAxMw==/0d4f9494324535fbf7602cde0838e39c.pdf"),
                                    InlineKeyboardButton.WithUrl("3К ОС Б", "https://knute.edu.ua/file/NDAxMw==/71c742681501dcbcc702bf4614897025.pdf"),
                                    InlineKeyboardButton.WithUrl("1К ОС М", "https://knute.edu.ua/file/NDAxMw==/9d31c47b1c979bddceb5572dcfcece68.pdf"),
                                },
                                new [] // second row
                                {
                                    InlineKeyboardButton.WithUrl("2К ОС МБ", "https://knute.edu.ua/file/NDAxMw==/561dff147550a9d118d4e0599f1c2626.pdf"),
                                    InlineKeyboardButton.WithUrl("2К ОС Б", "https://knute.edu.ua/file/NDAxMw==/0c3b60c55510eaf048111777b20d0089.pdf"),
                                    InlineKeyboardButton.WithUrl("4К ОС Б", "https://knute.edu.ua/file/NDAxMw==/792361d2711f794029b43ee3cff03dd5.pdf"),
                                    InlineKeyboardButton.WithUrl("2К ОС М", ""),
                                }
                            });
                        await client.SendTextMessageAsync(msg.Chat.Id, "Реєстр стипендіатів факультету інформаційних технологій:", replyMarkup: inlineKeyboard, parseMode: ParseMode.Markdown);
                    }
                    */
                    if (msg.Text == "Інформація")
                    {
                        var inlineKeyboard = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(new[]
                            {
                                new [] // first row
                                {
                                    InlineKeyboardButton.WithUrl("Події", "https://knute.edu.ua/blog/read/?pid=9957&uk"),
                                },
                                new [] // second row
                                {
                                    InlineKeyboardButton.WithUrl("Освітні програми", "https://knute.edu.ua/blog/read/?pid=29414&uk"),
                                    InlineKeyboardButton.WithUrl("Спеціальності", "https://knute.edu.ua/blog/read/?pid=79&uk"),
                                },
                                new [] // third row
                                {
                                    InlineKeyboardButton.WithUrl("Освітній процес", "https://knute.edu.ua/blog/read/?pid=7330&uk"),
                                    InlineKeyboardButton.WithUrl("Майбутнє випускників", "https://knute.edu.ua/blog/read/?pid=81&uk"),
                                }
                            });
                        await client.SendTextMessageAsync(msg.Chat.Id, "Корисна інформація факультету інформаційних технологій", replyMarkup: inlineKeyboard, parseMode: ParseMode.Markdown);
                    }
                    if (msg.Text == "Контакти")
                    {
                        await client.SendTextMessageAsync(msg.Chat.Id, "Декан Харченко Олександр Анатолійович (044) 531-47-07; моб. +380669510083  a.kharchenko@knute.edu.ua");
                        await client.SendTextMessageAsync(msg.Chat.Id, "Заступник декана з навчальної роботи Гнатченко Дмитро Дмитрович 531-48-87 hnatchenko@knute.edu.ua");
                        await client.SendTextMessageAsync(msg.Chat.Id, "Заступник декана з наукової і методичної роботи Хорольська Карина Вікторівна 531-48-87 k.khorolska@knute.edu.ua");
                        await client.SendTextMessageAsync(msg.Chat.Id, "Заступник декана з виховної роботи Лазоренко Віталій Валерійович 531-48-87 v.lazorenko@knute.edu.ua");
                    }
                    if (msg.Text == "Адміністрація факультету")
                    {
                        var inlineKeyboard = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(new[]
                            {
                                new [] // first row
                                {
                                    InlineKeyboardButton.WithUrl("посилання", "https://knute.edu.ua/blog/read/?pid=9&uk"),
                                }
                            });
                        await client.SendTextMessageAsync(msg.Chat.Id, "Адміністрація факультету", replyMarkup: inlineKeyboard, parseMode: ParseMode.Markdown);
                    }

                    client.OnCallbackQuery += async (object sc, Telegram.Bot.Args.CallbackQueryEventArgs ev) =>
                    { 
                        var message = ev.CallbackQuery.Message;
                        if (ev.CallbackQuery.Data == "Кафедри факультету")
                        {
                            var inlineKeyboard = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(new[]
                            {
                                new [] // first row
                                {
                                    InlineKeyboardButton.WithCallbackData("ЦЕ та СА"),
                                    InlineKeyboardButton.WithCallbackData("ІПЗ та КБ"),
                                },
                                new [] // second row
                                {
                                    InlineKeyboardButton.WithCallbackData("КН та ІС"),
                                    InlineKeyboardButton.WithCallbackData("В та ПМ"),
                                }
                            });
                            await client.SendTextMessageAsync(msg.Chat.Id, "До складу факультету входять 4 кафедри:", replyMarkup: inlineKeyboard, parseMode: ParseMode.Markdown);
                        }
                        if (ev.CallbackQuery.Data == "ЦЕ та СА")
                        {
                            var inlineKeyboard = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(new[]
                            {
                                new [] // first row
                                {
                                    InlineKeyboardButton.WithUrl("Детальніше", "https://knute.edu.ua/blog/read?n=Department%20of%20Economic%20Cybernetics%20and%20Information%20Systems&uk"),
                                }
                            });
                            await client.SendTextMessageAsync(msg.Chat.Id, "Кафедра цифрової економіки та системного аналізу, здійснює підготовку фахівців за освітньо-професійною програмою «Цифрова економіка» зі спеціальності 051 \"Економіка\" освітніх ступенів «бакалавр» і «магістр», за освітньо-професійною програмою «Інформаційні технології та бізнес-аналітика (Data Science)» зі спеціальності 124 «Системний аналіз»  освітнього ступеня «бакалавр» і \"магістр\", за освітньо-професійною програмою «Комп'ютерне та математичне моделювання» зі спеціальності 113 «Прикладна математика»  освітнього ступеня «бакалавр» та за освітньо-науковою програмою «Комп’ютерні науки» зі спеціальності 122 «Комп’ютерні науки» освітнього ступеня «Доктор філософії».", replyMarkup: inlineKeyboard, parseMode: ParseMode.Markdown);
                        }
                        if (ev.CallbackQuery.Data == "ІПЗ та КБ")
                        {
                            var inlineKeyboard = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(new[]
                            {
                                new [] // first row
                                {
                                    InlineKeyboardButton.WithUrl("Детальніше", "https://knute.edu.ua/blog/read?n=Department%20Software%20Engineering%20and%20Information%20Systems&uk"),
                                }
                            });
                            await client.SendTextMessageAsync(msg.Chat.Id, "Кафедра інженерії програмного забезпечення та кібербезпеки, здійснює підготовку фахівців за освітньо-професійною програмою «Інженерія програмного забезпечення» зі спеціальності 121 «Інженерія програмного забезпечення» освітніх ступенів «бакалавр» і «магістр», за освітньо-професійною програмою «Безпека інформаційних і комунікаційних систем в економіці» зі спеціальності 125 «Кібербезпека»  освітнього ступеня «бакалавр» та за освітньо-науковою програмою «Комп’ютерні науки» зі спеціальності 122 «Комп’ютерні науки» освітнього ступеня «Доктор філософії».", replyMarkup: inlineKeyboard, parseMode: ParseMode.Markdown);
                        }
                        if (ev.CallbackQuery.Data == "КН та ІС")
                        {
                            var inlineKeyboard = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(new[]
                            {
                                new [] // first row
                                {
                                    InlineKeyboardButton.WithUrl("Детальніше", "https://knute.edu.ua/blog/read?n=informaciynikh%20tekhnologiy%20u%20mizhnarodniy%20torgivli&uk"),
                                }
                            });
                            await client.SendTextMessageAsync(msg.Chat.Id, "Кафедра комп'ютерних наук та інформаційних систем  є випусковою для спеціальностей  122 \"Комп’ютерні науки\" та 126 \"Інформаційні системи і технології\" освітніх ступенів \"молодший бакалавр\" \"бакалавр\", \"магістр\" та \"доктор філософії\".", replyMarkup: inlineKeyboard, parseMode: ParseMode.Markdown);
                        }
                        if (ev.CallbackQuery.Data == "В та ПМ")
                        {
                            var inlineKeyboard = new Telegram.Bot.Types.ReplyMarkups.InlineKeyboardMarkup(new[]
                            {
                                new [] // first row
                                {
                                    InlineKeyboardButton.WithUrl("Детальніше", "https://knute.edu.ua/blog/read?n=Department%20of%20Higher%20and%20Applied%20Mathematics&uk"),
                                }
                            });
                            await client.SendTextMessageAsync(msg.Chat.Id, "Кафедра вищої та прикладної матиматики, ", replyMarkup: inlineKeyboard, parseMode: ParseMode.Markdown);
                        }
                    };
                }
                await client.SendTextMessageAsync(msg.Chat.Id, "Виберіть один із варіантів*", replyMarkup: GetButtons());
            }
        }

        private static IReplyMarkup GetButtons()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton { Text = "Головна сторінка" }, new KeyboardButton { Text = "Кафедри" }, new KeyboardButton { Text = "Реєстр стипендіатів" } },
                    new List<KeyboardButton>{ new KeyboardButton { Text = "Інформація" }, new KeyboardButton { Text = "Контакти" }, new KeyboardButton { Text = "Адміністрація факультету" } },
                }
            };
        }
    }
}