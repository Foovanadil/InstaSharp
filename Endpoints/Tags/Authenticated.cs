﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InstaSharp.Model.Responses;

namespace InstaSharp.Endpoints.Tags {
    public class Authenticated : InstagramAPI {

        readonly Unauthenticated _unauthenticated;

        public Authenticated(InstagramConfig config, AuthInfo auth)
            : base(config, auth, "/tags/") {
                _unauthenticated = new Unauthenticated(config);
        }

        public TagResponse Get(string tagName) {
            return _unauthenticated.Get(tagName);
        }

        public string GetJson(string tagName) {
            return _unauthenticated.GetJson(tagName);
        }

        public MediaResponse Recent(string tagName) {
            return _unauthenticated.Recent(tagName);
        }

        public string RecentJson(string tagName) {
            return _unauthenticated.RecentJson(tagName);
        }

        public TagsResponse Search(string searchTerm) {
            return _unauthenticated.Search(searchTerm);
        }

        public string SearchJson(string searchTerm) {
            return _unauthenticated.SearchJson(searchTerm);
        }
    }
}