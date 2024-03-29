﻿using AnimeNotificationsBot.Api.Messages.Base;
using AnimeNotificationsBot.Api.Models;
using AnimeNotificationsBot.BLL.Models.Animes;

namespace AnimeNotificationsBot.Api.Messages.Animes
{
    public class AnimeImagesMessage : MediaGroupMessage
    {
        public AnimeImagesMessage(List<AnimeModel> animes)
        {
            Images = animes
                .Where(x => x.ImgHref != null)
                .Select(x => new TelegramPhotoModel()
                {
                    Caption = x.TitleRu,
                    ImgHref = x.ImgHref,
                }).ToList();

            if (Images.Count == 1)
            {
                Images.First().Caption = null;
            }
        }
    }
}
