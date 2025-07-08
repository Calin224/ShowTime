using System;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Components.Forms;
using STime.Interfaces;

namespace STime.Services;

public class PhotoService : IPhotoService
{
    private readonly Cloudinary _cloudinary;

    public PhotoService(IConfiguration config)
    {
        var acc = new Account(config["CloudinarySettings:CloudName"], config["CloudinarySettings:ApiKey"],
            config["CloudinarySettings:ApiSecret"]);
        _cloudinary = new Cloudinary(acc);
    }

    public async Task<List<ImageUploadResult>> AddPhotosAsync(IBrowserFile? file)
    {
        var uploadResults = new List<ImageUploadResult>();


        var uploadResult = new ImageUploadResult();

        if (file.Size > 0)
        {
            using var stream = file.OpenReadStream();
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(file.Name, stream),
                Transformation = new Transformation().Gravity("face"),
                Folder = "da-net9"
            };

            uploadResult = await _cloudinary.UploadAsync(uploadParams);
        }

        uploadResults.Add(uploadResult);


        return uploadResults;
    }

    public async Task<DeletionResult> DeletePhotoAsync(string publicId)
    {
        var deleteParams = new DeletionParams(publicId);
        return await _cloudinary.DestroyAsync(deleteParams);
    }
}