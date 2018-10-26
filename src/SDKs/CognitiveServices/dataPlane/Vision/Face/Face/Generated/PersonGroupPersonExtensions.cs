// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PersonGroupPerson.
    /// </summary>
    public static partial class PersonGroupPersonExtensions
    {
            /// <summary>
            /// Create a new person in a specified person group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='name'>
            /// User defined name, maximum length is 128.
            /// </param>
            /// <param name='userData'>
            /// User specified data. Length should not exceed 16KB.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Person> CreateAsync(this IPersonGroupPerson operations, string personGroupId, string name = default(string), string userData = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(personGroupId, name, userData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all persons in a person group, and retrieve person information
            /// (including personId, name, userData and persistedFaceIds of registered
            /// faces of the person).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='start'>
            /// Starting person id to return (used to list a range of persons).
            /// </param>
            /// <param name='top'>
            /// Number of persons to return starting with the person id indicated by the
            /// 'start' parameter.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Person>> ListAsync(this IPersonGroupPerson operations, string personGroupId, string start = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(personGroupId, start, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete an existing person from a person group. Persisted face images of the
            /// person will also be deleted.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='personId'>
            /// Id referencing a particular person.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPersonGroupPerson operations, string personGroupId, System.Guid personId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(personGroupId, personId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve a person's information, including registered persisted faces, name
            /// and userData.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='personId'>
            /// Id referencing a particular person.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Person> GetAsync(this IPersonGroupPerson operations, string personGroupId, System.Guid personId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(personGroupId, personId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update name or userData of a person.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='personId'>
            /// Id referencing a particular person.
            /// </param>
            /// <param name='name'>
            /// User defined name, maximum length is 128.
            /// </param>
            /// <param name='userData'>
            /// User specified data. Length should not exceed 16KB.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IPersonGroupPerson operations, string personGroupId, System.Guid personId, string name = default(string), string userData = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(personGroupId, personId, name, userData, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete a face from a person. Relative image for the persisted face will
            /// also be deleted.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='personId'>
            /// Id referencing a particular person.
            /// </param>
            /// <param name='persistedFaceId'>
            /// Id referencing a particular persistedFaceId of an existing face.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteFaceAsync(this IPersonGroupPerson operations, string personGroupId, System.Guid personId, System.Guid persistedFaceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteFaceWithHttpMessagesAsync(personGroupId, personId, persistedFaceId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve information about a persisted face (specified by persistedFaceId,
            /// personId and its belonging personGroupId).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='personId'>
            /// Id referencing a particular person.
            /// </param>
            /// <param name='persistedFaceId'>
            /// Id referencing a particular persistedFaceId of an existing face.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PersistedFace> GetFaceAsync(this IPersonGroupPerson operations, string personGroupId, System.Guid personId, System.Guid persistedFaceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFaceWithHttpMessagesAsync(personGroupId, personId, persistedFaceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a person persisted face's userData field.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='personId'>
            /// Id referencing a particular person.
            /// </param>
            /// <param name='persistedFaceId'>
            /// Id referencing a particular persistedFaceId of an existing face.
            /// </param>
            /// <param name='userData'>
            /// User-provided data attached to the face. The size limit is 1KB.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateFaceAsync(this IPersonGroupPerson operations, string personGroupId, System.Guid personId, System.Guid persistedFaceId, string userData = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateFaceWithHttpMessagesAsync(personGroupId, personId, persistedFaceId, userData, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Add a representative face to a person for identification. The input face is
            /// specified as an image with a targetFace rectangle.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='personId'>
            /// Id referencing a particular person.
            /// </param>
            /// <param name='url'>
            /// Publicly reachable URL of an image
            /// </param>
            /// <param name='userData'>
            /// User-specified data about the face for any purpose. The maximum length is
            /// 1KB.
            /// </param>
            /// <param name='targetFace'>
            /// A face rectangle to specify the target face to be added to a person in the
            /// format of "targetFace=left,top,width,height". E.g.
            /// "targetFace=10,10,100,100". If there is more than one face in the image,
            /// targetFace is required to specify which face to add. No targetFace means
            /// there is only one face detected in the entire image.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PersistedFace> AddPersonFaceFromUrlAsync(this IPersonGroupPerson operations, string personGroupId, System.Guid personId, string url, string userData = default(string), IList<int> targetFace = default(IList<int>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddPersonFaceFromUrlWithHttpMessagesAsync(personGroupId, personId, url, userData, targetFace, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Add a representative face to a person for identification. The input face is
            /// specified as an image with a targetFace rectangle.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='personId'>
            /// Id referencing a particular person.
            /// </param>
            /// <param name='image'>
            /// An image stream.
            /// </param>
            /// <param name='userData'>
            /// User-specified data about the face for any purpose. The maximum length is
            /// 1KB.
            /// </param>
            /// <param name='targetFace'>
            /// A face rectangle to specify the target face to be added to a person in the
            /// format of "targetFace=left,top,width,height". E.g.
            /// "targetFace=10,10,100,100". If there is more than one face in the image,
            /// targetFace is required to specify which face to add. No targetFace means
            /// there is only one face detected in the entire image.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PersistedFace> AddPersonFaceFromStreamAsync(this IPersonGroupPerson operations, string personGroupId, System.Guid personId, Stream image, string userData = default(string), IList<int> targetFace = default(IList<int>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddPersonFaceFromStreamWithHttpMessagesAsync(personGroupId, personId, image, userData, targetFace, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}