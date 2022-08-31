/*-----------------------------------------------------------------------------------
	Template Name: Genial Blog HTML Template
	Template URI: https://webtend.net/demo/html/genial/
	Author: WebTend
	Author URI: https://webtend.net/
	Version: 1.0

	Note: This is Main js File For custom and jQuery plugins activation Code..
-----------------------------------------------------------------------------------

/*---------------------------
	JS INDEX
	===================
	01. Post masonary
	02. Post masonary
	03. Menu Click Functions
	04. Banner Slider
	05. Slider Animation
	06. Instagram Slider
	07. Photo stories
	08. Sticky Header
	10. Product Gallery
	09. Nice Select

-----------------------------*/

(function ($) {
	'use strict';

	/*-----------------------------
	=== ALL ESSENTIAL FUNCTIONS ===
	------------------------------*/
	// ===== 01. Post masonary
	function postMasonary() {
		$('#postWarpperLoaded').imagesLoaded(function () {
			$('.masonary-posts').isotope();
		});
	}

	// ===== 02. Post masonary
	function sidebarMasonary() {
		$('#postWarpperLoaded').imagesLoaded(function () {
			$('.sidebar-masonary').isotope();
		});
	}

	// ===== 03. Menu Click Functions
	function menuClickFun() {
		var panelBtn = $('.panel-btn'),
			panelClose = $('.panel-close'),
			panelArea = $('.offcanvas-panel'),
			panelOverly = $('.panel-overly'),
			panelMenu = $('.offcanvas-menu');

		panelBtn.on('click', function (e) {
			e.preventDefault();
			panelArea.addClass('panel-open');
		});

		panelClose.on('click', function (e) {
			e.preventDefault();
			panelArea.removeClass('panel-open');
		});

		panelOverly.on('click', function (e) {
			e.preventDefault();
			panelArea.removeClass('panel-open');
		});

		panelMenu.find('li a').each(function () {
			if ($(this).next().length > 0) {
				$(this).parent('li').append('<span class="dd-trigger"><i class="fal fa-angle-down"></i></span>');
			}
		});

		panelMenu.find('li .dd-trigger').on('click', function (e) {
			e.preventDefault();
			$(this).toggleClass('open').parent('li').children('ul').stop(true, true).slideToggle(350);
		});

		var searchBtn = $('.search-btn'),
			searchForm = $('.search-form'),
			searchClose = $('.search-close'),
			searchOverly = $('.search-overly');

		searchBtn.on('click', function (e) {
			e.preventDefault();
			searchForm.addClass('search-open');
		});

		searchClose.on('click', function (e) {
			e.preventDefault();
			searchForm.removeClass('search-open');
		});

		searchOverly.on('click', function (e) {
			e.preventDefault();
			searchForm.removeClass('search-open');
		});
	}

	// ===== 04. Banner Slider
	function bannerSlider() {
		var banner = $('.banner-slider');
		var bannerFirst = $('.sinlge-banner:first-child');

		banner.on('init', function (e, slick) {
			var firstAnimatingElements = bannerFirst.find(
				'[data-animation]'
			);
			slideanimate(firstAnimatingElements);
		});

		banner.on('beforeChange', function (
			e,
			slick,
			currentSlide,
			nextSlide
		) {
			var animatingElements = $(
				'div.slick-slide[data-slick-index="' + nextSlide + '"]'
			).find('[data-animation]');
			slideanimate(animatingElements);
		});

		banner.slick({
			infinite: true,
			slidesToShow: 1,
			slidesToScroll: 1,
			autoplay: false,
			autoplaySpeed: 5000,
			speed: 500,
			arrows: true,
			fade: true,
			dots: false,
			swipe: true,
			nextArrow: '<button class="slick-arrow next-arrow"><i class="far fa-angle-right"></i></button>',
			prevArrow: '<button class="slick-arrow prev-arrow"><i class="far fa-angle-left"></i></button>',
			appendArrows: $('.banner-nav'),
		});
	}

	// ===== 05. Slider Animation
	function slideanimate(elements) {
		var animationEndEvents =
			'webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend';
		elements.each(function () {
			var $this = $(this);
			var animationDelay = $this.data('delay');
			var animationType = 'animated ' + $this.data('animation');
			$this.css({
				'animation-delay': animationDelay,
				'-webkit-animation-delay': animationDelay,
			});
			$this
				.addClass(animationType)
				.one(animationEndEvents, function () {
					$this.removeClass(animationType);
				});
		});
	}

	// ===== 06. Instagram Slider
	function instagramlSlider() {
		var slide = $('.instagram-images');
		slide.slick({
			infinite: true,
			slidesToShow: 7,
			slidesToScroll: 1,
			autoplay: false,
			autoplaySpeed: 5000,
			speed: 500,
			arrows: false,
			fade: false,
			dots: false,
			swipe: true,
			responsive: [
				{
					breakpoint: 1200,
					settings: {
						slidesToShow: 6,
					}
				},
				{
					breakpoint: 992,
					settings: {
						slidesToShow: 5,
					}
				},
				{
					breakpoint: 768,
					settings: {
						slidesToShow: 4,
					}
				},
				{
					breakpoint: 576,
					settings: {
						slidesToShow: 2,
					}
				}
			],
		});
	}

	// ===== 07. Photo stories
	function photoStories() {
		$('#photoStoriesLoaded').imagesLoaded(function () {
			// Active isotope
			var items = $('.photo-stories').isotope({
				itemSelector: '.photo-item',
				masonry: {
					columnWidth: '.photo-item',
				},
			});
			// items on button click
			$('.photo-stories-nav').on('click', 'li', function () {
				var filterValue = $(this).attr('data-filter');
				items.isotope({
					filter: filterValue
				});
			});
			// menu active class
			$('.photo-stories-nav li').on('click', function (event) {
				$(this).siblings('.active').removeClass('active');
				$(this).addClass('active');
				event.preventDefault();
			});

			$('.photo-view').magnificPopup({
			});

			$('.photo-stories').magnificPopup({
				delegate: 'a',
				type: 'image',
				closeOnContentClick: false,
				closeBtnInside: false,
				gallery: {
					enabled: true
				},
			});
		});
	}

	// ===== 08. Sticky Header
	function stickyHeader() {
		var sticky = $('header.sticky-header');
		var scrollFromtop = $(window).scrollTop();
		var scrollLimit = $('header').height() + 10;

		if (scrollFromtop < scrollLimit) {
			sticky.removeClass('sticky-on');
		} else {
			sticky.addClass('sticky-on');
		}
	}

	// ===== 09. Product Gallery
	function productGallery() {
		var mainImageSlider = $('.main-images-slider'),
			dotsImageSlider = $('.dots-images-slider');

		mainImageSlider.slick({
			infinite: true,
			slidesToShow: 1,
			slidesToScroll: 1,
			autoplay: true,
			autoplaySpeed: 5000,
			speed: 500,
			arrows: false,
			fade: false,
			dots: false,
			swipe: true,
			asNavFor: dotsImageSlider,
		});

		dotsImageSlider.slick({
			infinite: true,
			slidesToShow: 3,
			slidesToScroll: 1,
			autoplay: true,
			autoplaySpeed: 5000,
			speed: 500,
			arrows: false,
			fade: false,
			dots: false,
			swipe: true,
			asNavFor: mainImageSlider,
			focusOnSelect: true,
		});
	}

	// ===== 10. Nice Select
	function niceSelect() {
		$('select').niceSelect();
	}

	/*---------------------
	=== DOCUMENT READY  ===
	----------------------*/
	$(document).ready(function () {
		menuClickFun();
		instagramlSlider();
		bannerSlider();
		photoStories();
		productGallery();
		niceSelect();
	});

	/*--------------------
	=== WINDOW SCROLL  ===
	----------------------*/
	$(window).on('scroll', function () {
		stickyHeader();
	});

	/*------------------
	=== WINDOW LOAD  ===
	--------------------*/
	$(window).on('load', function () {
		postMasonary();
		sidebarMasonary();
	});

})(jQuery);