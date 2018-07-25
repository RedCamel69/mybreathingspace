
// By Chris Coyier & tweaked by Mathias Bynens

    var $allVideos;
var $fluidEl;

$(function() {

    // Find all YouTube videos
    $allVideos = $("iframe[src^='https://www.youtube.com']"),

    // The element that is fluid width
	    $fluidEl = $("#media");

    // Figure out and save aspect ratio for each video
    $allVideos.each(function() {

		

    });

    // When the window is resized
    // (You'll probably want to debounce this)
    $(window).resize(function() {

        var newWidth = $fluidEl.width();

        // Resize all videos according to their own aspect ratio
        $allVideos.each(function() {

            if (newWidth < 500) {

                $(this)
			.data('aspectRatio', this.height / this.width)

			// and remove the hard coded width/height
			.removeAttr('height')
			.removeAttr('width');

                var $el = $(this);
                $el
                    .width(newWidth -10)
                    .height(newWidth -10  * $el.data('aspectRatio'));

            }
            else {

                $(this)

         // and remove the hard coded width/height
         .removeAttr('height')
         .removeAttr('width');

                var $el = $(this);
                $el
                    .width(560)
                    .height(315);
            }
        });

        // Kick off one resize to fix all videos on page load
    }).resize();

});

