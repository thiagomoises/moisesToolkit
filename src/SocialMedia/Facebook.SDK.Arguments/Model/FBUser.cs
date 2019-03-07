using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.SDK.Model
{
    public class FBUser
    {
        private Uri profilePictureUrl;


        /// <summary>
        /// Gets or sets the ID of the user.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Facebook username of the user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the first name of the user.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the middle name of the user.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the user.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the birthday of the user.
        /// </summary>
        public string Birthday { get; set; }

        /// <summary>
        /// Gets or sets the Facebook URL of the user.
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets the current city of the user.
        /// </summary>
        public FBLocation Location { get; set; }

        /// <summary>
        /// Gets or sets the URL of the user's profile picture.
        /// </summary>
        public Uri ProfilePictureUrl
        {
            get
            {
                return this.profilePictureUrl;
            }

            set
            {
                this.profilePictureUrl = value;
            }
        }
    }
}
