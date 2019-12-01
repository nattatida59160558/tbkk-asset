(function($) {
  "use strict"; // Start of use strict

  // Toggle the side navigation
  $("#sidebarToggle").on('click', function(e) {
    e.preventDefault();
    $("body").toggleClass("sidebar-toggled");
    $(".sidebar").toggleClass("toggled");
  });

  // Prevent the content wrapper from scrolling when the fixed side navigation hovered over
  $('body.fixed-nav .sidebar').on('mousewheel DOMMouseScroll wheel', function(e) {
    if ($(window).width() > 768) {
      var e0 = e.originalEvent,
        delta = e0.wheelDelta || -e0.detail;
      this.scrollTop += (delta < 0 ? 1 : -1) * 30;
      e.preventDefault();
    }
  });

  // Scroll to top button appear
  $(document).on('scroll', function() {
    var scrollDistance = $(this).scrollTop();
    if (scrollDistance > 100) {
      $('.scroll-to-top').fadeIn();
    } else {
      $('.scroll-to-top').fadeOut();
    }
  });

  // Smooth scrolling using jQuery easing
  $(document).on('click', 'a.scroll-to-top', function(event) {
    var $anchor = $(this);
    $('html, body').stop().animate({
      scrollTop: ($($anchor.attr('href')).offset().top)
    }, 1000, 'easeInOutExpo');
    event.preventDefault();
  });

})(jQuery); // End of use strict
$(function () {
    $('button[data-toggle="ajax-modal"]').click(function (event) {

        var url = '/Index?handler=ContactModalPartial';
        $.get(url).done(function (data) {

            $(document).append(data).find('.modal').modal('show');
        });
    });
});


        $(document).ready(function () {
            $('#btnUpload').on('click', function () {
                var fileExtension = ['xls', 'xlsx'];
                var filename = $('#fUpload').val();
                if (filename.length == 0) {
                    alert("Please select a file.");
                    return false;
                }
                else {
                    var extension = filename.replace(/^.*\./, '');
                    if ($.inArray(extension, fileExtension) == -1) {
                        alert("Please select only excel files.");
                        return false;
                    }
                }
                var fdata = new FormData();
                var fileUpload = $("#fUpload").get(0);
                var files = fileUpload.files;
                fdata.append(files[0].name, files[0]);
                $.ajax({
                    type: "POST",
                    url: "/Positions/Import?handler=Import",
                    beforeSend: function (xhr) {
                        xhr.setRequestHeader("XSRF-TOKEN",
                            $('input:hidden[name="__RequestVerificationToken"]').val());
                    },
                    data: fdata,
                    contentType: false,
                    processData: false,
                    success: function (response) {
                        if (response.length == 0)
                            alert('Some error occured while uploading');
                        else {
                            $('#dvData').html(response);
                        }
                    },
                    error: function (e) {
                        $('#dvData').html(e.responseText);
                    }
                });
            })
        });
