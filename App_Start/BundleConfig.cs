using System.Web;
using System.Web.Optimization;

namespace blogsite_asp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
        


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/libs/@popperjs/core/umd/popper.min.js",
                        "~/Content/libs/bootstrap/js/bootstrap.bundle.min.js",
                        "~/Content/js/defaultmenu.min.js",
                        "~/Content/libs/node-waves/waves.min.js",
                        "~/Content/js/sticky.js",
                        "~/Content/libs/simplebar/simplebar.min.js",
                        "~/Content/js/simplebar.js",
                        "~/Content/libs/@simonwep/pickr/pickr.es5.min.js",
                        "~/Content/js/custom-switcher.min.js",
                        "~/Content/libs/flatpickr/flatpickr.min.js",
                        "~/Content/libs/quill/quill.min.js",
                        "~/Content/libs/filepond/filepond.min.js",
                        "~/Content/libs/filepond-plugin-image-preview/filepond-plugin-image-preview.min.js",
                        "~/Content/libs/filepond-plugin-image-exif-orientation/filepond-plugin-image-exif-orientation.min.js",
                        "~/Content/libs/filepond-plugin-file-validate-size/filepond-plugin-file-validate-size.min.js",
                        "~/Content/libs/filepond-plugin-file-encode/filepond-plugin-file-encode.min.js",
                        "~/Content/libs/filepond-plugin-image-edit/filepond-plugin-image-edit.min.js",
                        "~/Content/js/blog-create.js",
                        "~/Content/js/custom.js",
                        "~/Content/js/main.js"
                        ));

        }
    }
}
