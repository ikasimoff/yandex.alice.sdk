﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Yandex.Alice.Sdk.Models.DialogsApi;

namespace Yandex.Alice.Sdk.Services
{
    public interface IDialogsApiService
    {
        Task<DialogsApiResponse<DialogsStatus>> StatusAsync();
        Task<DialogsApiResponse<DialogsImageUploadResponse>> UploadImageAsync(Guid skillId, DialogsWebUploadRequest request);
        Task<DialogsApiResponse<DialogsImageUploadResponse>> UploadImageAsync(Guid skillId, DialogsFileUploadRequest request);
        Task<DialogsApiResponse<DialogsImagesInfoList>> GetImagesAsync(Guid skillId);
        Task<DialogsApiResponse<DialogsDeleteResponse>> DeleteImageAsync(Guid skillId, string imageId);
        Task<DialogsApiResponse<DialogsSoundResponse>> UploadSoundAsync(Guid skillId, DialogsFileUploadRequest request);
        Task<DialogsApiResponse<DialogsSoundResponse>> GetSoundAsync(Guid skillId, Guid soundId);
        Task<DialogsApiResponse<DialogsSoundsInfoList>> GetSoundsAsync(Guid skillId);
        Task<DialogsApiResponse<DialogsDeleteResponse>> DeleteSoundAsync(Guid skillId, Guid soundId);

    }
}
