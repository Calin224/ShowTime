using System;
using CloudinaryDotNet.Actions;

namespace STime.Interfaces;

public interface IPhotoService
{
    Task<List<ImageUploadResult>> AddPhotosAsync(List<IFormFile> files);
    Task<DeletionResult> DeletePhotoAsync(string publicId);
}
