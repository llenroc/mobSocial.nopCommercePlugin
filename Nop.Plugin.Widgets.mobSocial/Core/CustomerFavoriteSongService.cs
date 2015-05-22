﻿using System;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using Nop.Core;
using Nop.Core.Data;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Media;
using Nop.Plugin.Widgets.MobSocial.Domain;
using Nop.Services.Configuration;
using Nop.Services.Events;
using Nop.Services.Logging;
using Nop.Services.Media;
using System.Drawing;
using System.Linq;
using Nop.Services.Seo;
using Nop.Core.Domain.Seo;
using System.Collections.Generic;


namespace Nop.Plugin.Widgets.MobSocial.Core
{
    public class CustomerFavoriteSongService : BaseService<CustomerFavoriteSong, CustomerFavoriteSong>, ICustomerFavoriteSongService
    {
        private MediaSettings _nopMediaSettings;
        private IUrlRecordService _urlRecordService;
        private readonly IPictureService _pictureService;
        private IWorkContext _workContext;

        public CustomerFavoriteSongService(ISettingService settingService, IWebHelper webHelper,
            ILogger logger, IEventPublisher eventPublisher,
            IRepository<CustomerFavoriteSong> entityRepository,
            IRepository<CustomerFavoriteSong> entityPictureRepository,
            MediaSettings mediaSettings,
            IUrlRecordService urlRecordService,
            IPictureService pictureService,
            IWorkContext workContext) : base(entityRepository, entityPictureRepository, workContext, urlRecordService)
        {
            _nopMediaSettings = mediaSettings;
            _urlRecordService = urlRecordService;
            _pictureService = pictureService;
            _workContext = workContext;
        }


        public List<CustomerFavoriteSong> GetTop10(int customerId)
        {
            return Repository.Table
                .Where(x => x.CustomerId == customerId)
                .OrderBy(x => x.DisplayOrder)
                .Take(10)
                .ToList();
        }

        /// <summary>
        /// Gets all pictures for the specified entity
        /// </summary>
        /// <returns></returns>
        public override List<CustomerFavoriteSong> GetAllPictures(int entityId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the first entity picture for the specified entity from EntityPicture table
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public override CustomerFavoriteSong GetFirstEntityPicture(int entityId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the first picture for the specified entity
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public override Picture GetFirstPicture(int entityId)
        {
            throw new NotImplementedException();
        }

        public override List<CustomerFavoriteSong> GetAll(string term, int count)
        {
            throw new NotImplementedException();
        }




    }

}
