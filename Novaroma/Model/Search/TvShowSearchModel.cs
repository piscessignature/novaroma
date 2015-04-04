﻿using System.Collections.ObjectModel;

namespace Novaroma.Model.Search {

    public class TvShowSearchModel: MediaSearchModel {

        public TvShowSearchModel(ObservableCollection<string> mediaGenres): base(mediaGenres) {
        }
    }
}
