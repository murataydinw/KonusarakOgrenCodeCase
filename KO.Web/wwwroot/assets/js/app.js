var App = function () {

    var width = $(window).width();
    var height = $(window).height();
    var xs = 0;
    var sm = 768;
    var md = 992;
    var lg = 1200;


    var plugins = function () {
        if ($('body').hasClass('language-ar')) {
            var rtl = true;
        } else {
            var rtl = false;
        }

        $('form').validationEngine();
        $('.center-image').centerImage();
        $(':input').inputmask();
        $('input[type="checkbox"], input[type="radio"]').checkRadio();
        $('.hospital-comment-list.has-carousel .list .row').slick({
            rtl: rtl
        });
        $('.hospital-video-box.has-carousel .other-video .list .row').slick({
            slidesToShow: 3,
            rtl         : rtl,
            responsive  : [
                {
                    breakpoint: 1200,
                    settings  : {
                        slidesToShow: 2,
                    }
                },
                {
                    breakpoint: 768,
                    settings  : {
                        slidesToShow: 1,
                    }
                }
            ]
        });
        $('.dropzone-list .dz-item .item-icon').fancybox();
        $('.fancybox').fancybox();
        $('section.home-content .home-accreditation-list .row').slick({
            slidesToShow: 4,
            dots        : false,
            arrows      : false,
            rtl         : rtl,
            responsive  : [
                {
                    breakpoint: 768,
                    settings  : {
                        slidesToShow: 1,
                    }
                },
                {
                    breakpoint: 1024,
                    settings  : {
                        slidesToShow: 2,
                    }
                },

            ]
        });
        $('.has-scroll').niceScroll();
        $('.js-currency-mask').maskMoney({
            precision: 0
        });
    };

    var internationalInputTel = function () {
        var input = $('.js-int-phone');
        input.intlTelInput({
            preferredCountries: ["gb", "de", "ru", "az", "sa", "fr", "es", "nl"],
        });
        input.on("countrychange", function (e, countryData) {
            $(this).val('+' + countryData['dialCode']);
        });
    }

    var slider = function () {
        $('.slider-box .rev_slider').revolution({
            delay           : 5000,
            visibilityLevels: [2048, 1024, 778, 480],	// Single or Array for Responsive Visibility Levels i.e.: 4064 or i.e. [2048, 1024, 768, 480]
            responsiveLevels: [2048, 1183, 1007, 480],					// Single or Array for Responsive Levels i.e.: 4064 or i.e. [2048, 1024, 768, 480]
            gridwidth       : [1140, 720, 720, 480],							// Single or Array i.e. 960 or [960, 840,760,460]
            gridheight      : [705, 705, 550, 705],							// Single or Array i.e. 500 or [500, 450,400,350]
            minHeight       : 0,
            autoHeight      : "off",
            sliderType      : "standard",				// standard, carousel, hero
            sliderLayout    : "auto",					// auto, fullwidth, fullscreen

            fullScreenAutoWidth      : "off",				// Turns the FullScreen Slider to be a FullHeight but auto Width Slider
            fullScreenAlignForce     : "off",
            fullScreenOffsetContainer: "",			// Size for FullScreen Slider minimising Calculated on the Container sizes
            fullScreenOffset         : "0",					// Size for FullScreen Slider minimising

            hideCaptionAtLimit   : 0,					// It Defines if a caption should be shown under a Screen Resolution ( Basod on The Width of Browser)
            hideAllCaptionAtLimit: 0,				// Hide all The Captions if Width of Browser is less then this value
            hideSliderAtLimit    : 0,					// Hide the whole slider, and stop also functions if Width of Browser is less than this value
            disableProgressBar   : "off",				// Hides Progress Bar if is set to "on"
            stopAtSlide          : false,							// Stop Timer if Slide "x" has been Reached. If stopAfterLoops set to 0, then it stops already in the first Loop at slide X which defined. -1 means do not stop at any slide. stopAfterLoops has no sinn in this case.
            stopAfterLoops       : -1,						// Stop Timer if All slides has been played "x" times. IT will stop at THe slide which is defined via stopAtSlide:x, if set to -1 slide never stop automatic
            shadow               : 0,								//0 = no Shadow, 1,2,3 = 3 Different Art of Shadows  (No Shadow in Fullwidth Version !)
            dottedOverlay        : "none",					//twoxtwo, threexthree, twoxtwowhite, threexthreewhite
            startDelay           : 0,							// Delay before the first Animation starts.
            lazyType             : "smart",						//full, smart, single
            spinner              : "spinner0",
            shuffle              : "off",							// Random Order of Slides,

            viewPort         : {
                enable      : false,						// if enabled, slider wait with start or wait at first slide.
                outof       : "wait",						// wait,pause
                visible_area: "60%",					// Start Animation when 60% of Slider is visible
                presize     : false 						// Presize the Height of the Slider Container for Internal Link Positions
            },
            fallbacks        : {
                isJoomla               : false,
                panZoomDisableOnMobile : "off",
                simplifyAll            : "on",
                nextSlideOnWindowFocus : "off",
                disableFocusListener   : true,
                ignoreHeightChanges    : "off",  // off, mobile, always
                ignoreHeightChangesSize: 0

            },
            parallax         : {
                type              : "off",						// off, mouse, scroll, mouse+scroll
                levels            : [10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85],
                origo             : "enterpoint",				// slidercenter or enterpoint
                speed             : 400,
                bgparallax        : "off",
                opacity           : "on",
                disable_onmobile  : "off",
                ddd_shadow        : "on",
                ddd_bgfreeze      : "off",
                ddd_overflow      : "visible",
                ddd_layer_overflow: "visible",
                ddd_z_correction  : 65,
                ddd_path          : "mouse"
            },
            scrolleffect     : {
                fade                     : "off",
                blur                     : "off",
                grayscale                : "off",
                maxblur                  : 10,
                on_layers                : "off",
                on_slidebg               : "off",
                on_static_layers         : "off",
                on_parallax_layers       : "off",
                on_parallax_static_layers: "off",
                direction                : "both",
                multiplicator            : 1.35,
                multiplicator_layers     : 0.5,
                tilt                     : 30,
                disable_on_mobile        : "on"
            },
            carousel         : {
                easing           : punchgs.Power3.easeInOut,
                speed            : 800,
                showLayersAllTime: "off",
                horizontal_align : "center",
                vertical_align   : "center",
                infinity         : "on",
                space            : 0,
                maxVisibleItems  : 3,
                stretch          : "off",
                fadeout          : "on",
                maxRotation      : 0,
                minScale         : 0,
                vary_fade        : "off",
                vary_rotation    : "on",
                vary_scale       : "off",
                border_radius    : "0px",
                padding_top      : 0,
                padding_bottom   : 0
            },
            navigation       : {
                keyboardNavigation   : "off",
                keyboard_direction   : "horizontal",		//	horizontal - left/right arrows,  vertical - top/bottom arrows
                mouseScrollNavigation: "off",			// on, off, carousel
                onHoverStop          : "off",						// Stop Banner Timet at Hover on Slide on/off

                touch     : {
                    touchenabled       : "off",						// Enable Swipe Function : on/off
                    swipe_treshold     : 75,					// The number of pixels that the user must move their finger by before it is considered a swipe.
                    swipe_min_touches  : 1,					// Min Finger (touch) used for swipe
                    drag_block_vertical: false,				// Prevent Vertical Scroll during Swipe
                    swipe_direction    : "horizontal"
                },
                arrows    : {
                    style            : "",
                    enable           : false,
                    hide_onmobile    : false,
                    hide_onleave     : true,
                    hide_delay       : 200,
                    hide_delay_mobile: 1200,
                    hide_under       : 0,
                    hide_over        : 9999,
                    tmp              : '',
                    rtl              : false,
                    left             : {
                        h_align  : "left",
                        v_align  : "center",
                        h_offset : 20,
                        v_offset : 0,
                        container: "slider",
                    },
                    right            : {
                        h_align  : "right",
                        v_align  : "center",
                        h_offset : 20,
                        v_offset : 0,
                        container: "slider",
                    }
                },
                bullets   : {
                    container        : "slider",
                    rtl              : false,
                    style            : "",
                    enable           : true,
                    hide_onmobile    : false,
                    hide_onleave     : false,
                    hide_delay       : 200,
                    hide_delay_mobile: 1200,
                    hide_under       : 0,
                    hide_over        : 9999,
                    direction        : "vertical",
                    h_align          : "right",
                    v_align          : "center",
                    space            : 10,
                    h_offset         : 20,
                    v_offset         : 0,
                    tmp              : '<span class="tp-bullet-image"></span><span class="tp-bullet-title"></span>'
                },
                thumbnails: {
                    container        : "slider",
                    rtl              : false,
                    style            : "",
                    enable           : false,
                    width            : 100,
                    height           : 50,
                    min_width        : 100,
                    wrapper_padding  : 2,
                    wrapper_color    : "#f5f5f5",
                    wrapper_opacity  : 1,
                    tmp              : '<span class="tp-thumb-image"></span><span class="tp-thumb-title"></span>',
                    visibleAmount    : 5,
                    hide_onmobile    : false,
                    hide_onleave     : true,
                    hide_delay       : 200,
                    hide_delay_mobile: 1200,
                    hide_under       : 0,
                    hide_over        : 9999,
                    direction        : "horizontal",
                    span             : false,
                    position         : "inner",
                    space            : 2,
                    h_align          : "left",
                    v_align          : "center",
                    h_offset         : 20,
                    v_offset         : 0
                },
                tabs      : {
                    container        : "slider",
                    rtl              : false,
                    style            : "",
                    enable           : false,
                    width            : 100,
                    min_width        : 100,
                    height           : 50,
                    wrapper_padding  : 10,
                    wrapper_color    : "#f5f5f5",
                    wrapper_opacity  : 1,
                    tmp              : '<span class="tp-tab-image"></span>',
                    visibleAmount    : 5,
                    hide_onmobile    : false,
                    hide_onleave     : true,
                    hide_delay       : 200,
                    hide_delay_mobile: 1200,
                    hide_under       : 0,
                    hide_over        : 9999,
                    direction        : "horizontal",
                    span             : false,
                    space            : 0,
                    position         : "inner",
                    h_align          : "left",
                    v_align          : "center",
                    h_offset         : 20,
                    v_offset         : 0
                }
            },
            extensions       : "extensions/",			//example extensions/ or extensions/source/
            extensions_suffix: ".min.js",
            //addons:[{fileprefix:"revolution.addon.whiteboard",init:"initWhiteBoard",params:"opt",handel:"whiteboard"}],
            debugMode        : false
        });
    };

    var mobileMenuEvent = function () {
        var panel = $('header.site-head .block-right');
        var el = $('header.site-head .menu-btn');

        var sidebarBtn = $('.show-sidebar-menu');
        var sidebar = $('.page-sidebar');

        el.click(function () {
            if (el.hasClass('active')) {
                ready.mobileMenuClose(panel, el);
            } else {
                ready.mobileMenuOpen(panel, el);
            }
        });
        $('.overlay').on('click', function () {
            ready.mobileMenuClose(panel, el);
            sidebarBtn.removeClass('active');
            sidebar.removeClass('active');
        });
    };

    var placeMarkMap = function () {
        var marker, i;

        var latlng = new google.maps.LatLng(39.1488404, 35.4439873);
        var mapOptions = {
            scrollwheel       : false,
            disableDefaultUI  : true,
            zoom              : 4,
            zoomControl       : true,
            zoomControlOptions: {
                style: google.maps.ZoomControlStyle.SMALL
            },
            center            : latlng,
            styles            : [{
                "featureType": "administrative",
                "elementType": "all",
                "stylers"    : [{"visibility": "on"}, {"saturation": -100}, {"lightness": 20}]
            }, {
                "featureType": "road",
                "elementType": "all",
                "stylers"    : [{"visibility": "on"}, {"saturation": -100}, {"lightness": 40}]
            }, {
                "featureType": "water",
                "elementType": "all",
                "stylers"    : [{"visibility": "on"}, {"saturation": -10}, {"lightness": 30}]
            }, {
                "featureType": "landscape.man_made",
                "elementType": "all",
                "stylers"    : [{"visibility": "simplified"}, {"saturation": -60}, {"lightness": 10}]
            }, {
                "featureType": "landscape.natural",
                "elementType": "all",
                "stylers"    : [{"visibility": "simplified"}, {"saturation": -60}, {"lightness": 60}]
            }, {
                "featureType": "poi",
                "elementType": "all",
                "stylers"    : [{"visibility": "off"}, {"saturation": -100}, {"lightness": 60}]
            }, {
                "featureType": "transit",
                "elementType": "all",
                "stylers"    : [{"visibility": "off"}, {"saturation": -100}, {"lightness": 60}]
            }]
        };

        function setMap(address) {
            console.log(address);
            var geocoder = new google.maps.Geocoder();
            geocoder.geocode({'address': address}, function (results, status) {
                if (status === google.maps.GeocoderStatus.OK) {
                    var userLat = results[0].geometry.location.lat();
                    var userLng = results[0].geometry.location.lng();
                    map.setCenter(new google.maps.LatLng(userLat, userLng));
                    addMarker(new google.maps.LatLng(userLat, userLng))
                } else {
                    // console.log('Geocode was not successful for the following reason: ' + results);
                }
            });
        }

        function addMarker(location) {
            if (marker) {
                marker.setPosition(location);
            } else {
                marker = new google.maps.Marker({
                    position : location,
                    map      : map,
                    draggable: true
                });
                marker.addListener('dragend', toggleBounce);
            }
            toggleBounce();
        }

        function toggleBounce() {
            var position = marker.getPosition();
            $('.js-lat').val(position['lat']);
            $('.js-lng').val(position['lng']);
        }

        function changeSelectMarker() {
            $('.js-select-marker').on('change', function () {
                var mapType = $(this).attr('data-map-type');
                if (mapType == 'country') {
                    setMap($('.js-address-detail').val() + ', ' + $('.js-select-country').val());
                    map.setZoom(4);
                }
                else {
                    setMap($('.js-address-detail').val() + ', ' + $('.js-select-city').val() + ', ' + $('.js-select-country').val());
                    map.setZoom(8);
                }
            });
        }

        function showMapsUpdateBtn() {
            $('.js-address-detail').on('keyup', function () {
                if ($(this).val().length > 3) {
                    $('.js-address-detail-btn').fadeIn();
                } else {
                    $('.js-address-detail-btn').fadeOut();
                }
            });
        }

        function mapsUpdateEvent() {
            $('.js-address-detail-btn').click(function () {
                setMap($('.js-address-detail').val() + ', ' + $('.js-select-city').val() + ', ' + $('.js-select-country').val());
                map.setZoom(15);
                $('.place-mark-area .help-block').fadeIn();
            })
        }

        if ($('#place-mark').length > 0) {
            var map = new google.maps.Map(document.getElementById('place-mark'), mapOptions);
            changeSelectMarker();
            showMapsUpdateBtn();
            mapsUpdateEvent();
        }
    };

    var tabbed = function () {
        var tab = $('.has-tab');
        var el = tab.find('.tab-head ul li a');
        var div = tab.find('.tab-body .tab-item');

        el.on('click', function (e) {
            e.preventDefault();
            var tabId = $(this).attr('data-tab-id');
            if ($(this).parent().hasClass('active')) {

            }
            else {
                el.parent().removeClass('active');
                $(this).parent().addClass('active');

                div.removeClass('active');
                tab.find('.tab-body .tab-item[data-tab-id="' + tabId + '"]').addClass('active');
            }
        });
    };

    var hospitalDetailContent = function () {
        if ($('body').hasClass('language-ar')) {
            var rtl = true;
        } else {
            var rtl = false;
        }

        var thumbList = $('section.detail-content .hospital-banner-thumb .list');
        var galleryList = $('section.detail-content .hospital-banner .list');

        /*galleryList.slick({
            slidesToShow  : 1,
            slidesToScroll: 1,
            dots          : false,
            arrows        : false,
            asNavFor      : 'section.detail-content .hospital-banner-thumb .list',
            autoplay      : true,
            autoplaySpeed : 3000,
            rtl           : rtl,
            responsive    : [
                {
                    breakpoint: 768,
                    settings  : {
                        dots        : true,
                        customPaging: function (slider, i) {
                            return '<button type="button" class="btn btn-link"></button>';
                        },
                    }
                }
            ]
        });*/

        /*thumbList.slick({
            slidesToShow  : 3,
            slidesToScroll: 1,
            dots          : false,
            arrows        : false,
            focusOnSelect : true,
            rtl           : rtl,
            asNavFor      : 'section.detail-content .hospital-banner .list',
            responsive    : [
                {
                    breakpoint: 1200,
                    settings  : {
                        slidesToShow: 3,
                    }
                },
                {
                    breakpoint: 768,
                    settings  : {
                        slidesToShow: 2,
                    }
                }
            ]
        })*/
    };

    this.showOfferDetail = function (item) {
        var el = $('.js-show-offer-detail');

        function hide(div) {
            div.removeClass('active');
            div.find('.item-detail').hide();
            el.text(el.attr('data-show-text'));
        }
        function show(div) {
            div.addClass('active');
            div.find('.item-detail').show();
            el.text(el.attr('data-hide-text'));
        }

        el.on('click', function (e) {
            e.preventDefault();
            var item = $(this).parents('.item');

            console.log($(this));

            if (item.hasClass('active')) {
                hide(item);
            }
            else {
                show(item);
            }
        });

        if (item) {
            if (item.hasClass('active')) {
                hide(item,el);
            }
            else {
                show(item,el);
            }
        }
    };

    var accordion = function () {
        var accordion = $('.accordion');
        var item = accordion.find('.accordion-item');
        var el = item.find('.accordion-head');
        var body = item.find('.accordion-body');

        function scrolling(div) {
            $('html,body').animate({
                scrollTop: div.offset().top - ($('header.site-head').height() + 20)
            });
        }

        el.on('click', function () {
            if ($(this).parent().hasClass('active')) {
                $(this).parent().removeClass('active');
                $(this).parent().find('.accordion-body').slideUp().dequeue();
                scrolling($(this).parent());
            }
            else {
                item.removeClass('active');
                $(this).parent().addClass('active');

                body.slideUp().dequeue();
                $(this).parent().find('.accordion-body').slideDown().queue(function () {
                    scrolling($(this).parent());
                });
            }
        });
    };

    var aboutUsMenuScrolling = function () {
        var item = $('section.about-us-content .page-block-menu ul li a');

        if ($(window).width() < 768) {
            var differenceMobil = 65;
        }
        else {
            var differenceMobil = 65;
        }

        item.on('click', function (e) {
            e.preventDefault();
            var div = $(this).attr('href');

            item.parent().removeClass('active');
            $(this).parent().addClass('active');

            $('html, body').animate({
                scrollTop: ($(div).offset().top - (50 + differenceMobil))
            });
            if ($(window).width() < 768) {
                var el = $('section.about-us-content .page-block-menu .show-menu');

                el.removeClass('active');
                el.parent().animate({
                    'height': 65 * 1
                });
            }
        });
    };

    var stepPie = function () {
        var $ppc = $('.progress-pie-chart'),
            percent = parseInt($ppc.data('percent')),
            deg = 360 * percent / 100;
        if (percent > 50) {
            $ppc.addClass('gt-50');
        }
        $('.ppc-progress-fill').css('transform', 'rotate(' + deg + 'deg)');
        $('.ppc-percents span').html(percent + '%');
    };

    var copyBankInfo = function () {
        $('.bank-info-list .item .copy-btn').on('click', function (e) {
            e.preventDefault();
            copyTextToClipboard($(this));
        });
    };

    var copyTextToClipboard = function (el) {
        var textArea = document.createElement("textarea");

        textArea.value = el.prev().val();

        document.body.appendChild(textArea);

        textArea.select();

        try {
            var successful = document.execCommand('copy');
            var msg = successful ? 'successful' : 'unsuccessful';
            el.find('span').html('Panoya Kopyalandı!');
            setTimeout(function () {
                el.find('span').html('');
            }, 2000);
        } catch (err) {
            el.find('span').html('Hata');
        }

        document.body.removeChild(textArea);
    };

    var addProfileImage = function () {
        $('.js-add-image-btn').on('click', function () {
            $('.js-add-image-input').trigger('click');
        });
    };

    var aboutUsMobileMenu = function () {
        $('section.about-us-content .page-block-menu .show-menu').on('click', function () {
            if ($(this).hasClass('active')) {
                $(this).removeClass('active');
                $(this).parent().animate({
                    'height': 65 * 1
                });
            }
            else {
                $(this).addClass('active');
                $(this).parent().animate({
                    'height': 65 * 5
                });
            }
        });
    };

    var showSidebarEvent = function () {
        var el = $('.show-sidebar-menu');
        var sidebar = $('.page-sidebar');

        el.on('click', function () {
            if ($(this).hasClass('active')) {
                sidebar.removeClass('active');
                el.removeClass('active');
                $('.overlay').fadeOut();
                $('body').css('overflow', 'auto');
            }
            else {
                sidebar.addClass('active');
                el.addClass('active');
                $('.overlay').fadeIn();
                $('body').css('overflow', 'hidden');
            }
        });
    };

    this.messageListScrollBottom = function () {
        $('.profile-message-list .item .item-message-list .has-scroll').animate({
            scrollTop: $(document).height()
        }, 1000);
    };

    var agencyChangePriceRatio = function () {
        var select = $('.js-change-agency-ratio');
        var input = $('.js-change-agency-ratio-input');

        if (select.length > 0) {
            input.prop('disabled', true);
        }

        select.on('change', function () {
            var value = $(this).val();
            var value = parseInt(value) * 2;

            input.html('');
            for (var i = value; i <= 100; i += 5) {
                input.append('<option value="' + i + '">' + i + '%</option>');
            }
            input.selectpicker('refresh');
        });
    };

    var orderCalculateValue = function () {
        function toInteger(deger) {
            if (deger == '') {
                return 0;
            } else {
                return parseInt(deger.replace(/[^\d.]/g, ''))
            }
        }

        var el = $('.js-calculate-value');
        var totalResult = $('.js-calc-total-value');
        var preOrderResult = $('.js-calc-pre-order-value');

        el.on('change keypress keyup', function () {
            var treatmentVal = toInteger($('.js-calculate-value[data-type="treatment"]').val());
            var serviceVal = toInteger($('.js-calculate-value[data-type="service"]').val());
            var preOrderRatio = toInteger($('.js-calculate-value[data-type="pre-order"]').val());
            var discountRatio = toInteger($('.js-calculate-value[data-type="discount"]').val());

            if ($('.js-calculate-value[data-type="commision"]').length > 0) {
                var commisionRatio = parseInt($('.js-calculate-value[data-type="commision"]').val().replace(/[^\d.]/g, ''));
            } else {
                commisionRatio = 0;
            }

            var discountVal = ((treatmentVal / 100) * discountRatio);
            treatmentVal = treatmentVal - discountVal;
            var commisionVal = ((treatmentVal / 100) * commisionRatio);
            var totalVal = treatmentVal + serviceVal;
            // totalVal = totalVal - commisionVal;
            var preOrderVal = ((totalVal / 100) * (preOrderRatio));

            totalResult.html(totalVal);
            preOrderResult.html(preOrderVal);
            $('.js-agency-commision-val').text(commisionVal);
            $('#hdnTotalPrice').val(totalVal);
            $('#hdnPreOrderPrice').val(preOrderVal);
        });
    };

    var messagesAreaAddFile = function () {
        var button = $('.js-messages-button');
        var file = $('.js-messages-input');

        button.on('click', function () {
            file.trigger('click');
        });
    };

    var paidServicesEvent = function () {
        var el = $('.js-paid-services-button');
        var totalVal = parseInt($('.js-paid-services-total-val input').val());
        var servicesVal = parseInt($('.js-paid-services-paid-val input').val());
        var infoBox = $('.js-paid-services-box');
        var orderTotal = $('.js-order-total-val');

        function addServices() {
            infoBox.show();
            var currentVal = totalVal + servicesVal;
            orderTotal.text(currentVal);
        }
        function removeServices() {
            infoBox.hide();
            var currentVal = totalVal;
            orderTotal.text(currentVal);
        }

        el.on('change', function () {
            if ($(this).is(':checked') === false) {
                removeServices();
            } else {
                addServices();
            }
        })
    };

    var changeCurrencyEvent = function () {
        var el = $('.js-change-currency');
        var icon = $('.js-currency-icon');

        el.on('change', function () {
            var faIcon = $(this).val();
            icon.attr({
                "class" : "js-currency-icon fa fa-"+faIcon
            })
        });
    };

    this.showDetailBtn = function (hide, show) {
        var btn = $('section.detail-content .page-block .block-body .more-btn');
        var article = $('.page-block .block-body article.min-height');

        btn.on('click', function () {
            if ($(this).hasClass('active')) {
                $(this).removeClass('active');
                $(this).prev().addClass('min-height');
                $(this).find('span.text').text(show);
            } else {
                $(this).addClass('active');
                $(this).prev().removeClass('min-height');
                $(this).find('span.text').text(hide);
            }
        });
    };

    this.mobileMenuOpen = function (panel, el) {
        panel.animate({
            'right': 0
        });
        $('.overlay').fadeIn();
        $('body').css({
            'overflow': 'hidden'
        });
        el.addClass('active');
    };

    this.mobileMenuClose = function (panel, el) {
        panel.animate({
            'right': '-280px'
        });
        $('.overlay').fadeOut();
        $('body').css({
            'overflow': 'auto'
        });
        el.removeClass('active');
    };

    this.run = function () {
        plugins();
        placeMarkMap();
        tabbed();
        ready.showOfferDetail();
        // slider();
        hospitalDetailContent();
        accordion();
        aboutUsMenuScrolling();
        stepPie();
        copyBankInfo();
        addProfileImage();
        mobileMenuEvent();
        aboutUsMobileMenu();
        showSidebarEvent();
        ready.messageListScrollBottom();
        agencyChangePriceRatio();
        orderCalculateValue();
        messagesAreaAddFile();
        paidServicesEvent();
        changeCurrencyEvent();
    }
};
var ready = new App();

$(document).ready(function () {
    ready.run();
});