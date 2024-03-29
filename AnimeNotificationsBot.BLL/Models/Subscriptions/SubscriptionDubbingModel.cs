﻿using AnimeNotificationsBot.BLL.Models.Dubbing;

namespace AnimeNotificationsBot.BLL.Models.Subscriptions
{
    public class SubscriptionDubbingModel
    {
        public long AnimeId { get; set; }

        public required DubbingModel Dubbing { get; set; }

        public bool HasSubscribe { get; set; }
    }
}
