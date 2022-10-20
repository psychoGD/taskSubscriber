using Cinema_MVVM_PROJECT_WPF.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp5.Models;

namespace WpfApp5.ViewModels
{
    public class PostViewModel
    {
        public Post Post { get; set; }

        public RelayCommand FollowCommand { get; set; }
        public PostViewModel(Post post)
        {
            Post = post;
            FollowCommand = new RelayCommand(o =>
            {
                Post.subscribers.Add(App.subscriber);

            });
        }

    }
}
