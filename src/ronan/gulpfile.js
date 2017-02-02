/// <binding ProjectOpened='watch-sass' />
var gulp = require('gulp');
var gulpSass = require('gulp-sass');
var cleanCSS = require('gulp-clean-css');




gulp.task('compile-bootstrap', function () {

    gulp.src('./wwwroot/lib/bootstrap/scss/bootstrap.scss')

        .pipe(gulpSass())
        .pipe(cleanCSS())
        .pipe(gulp.dest('./wwwroot/css'));
});

gulp.task('compile-sass', function () {

    gulp.src('./wwwroot/sass/default.scss')
        .pipe(gulpSass())
        .pipe(cleanCSS())
        .pipe(gulp.dest('./wwwroot/css'));
});

gulp.task('watch-sass', function () {
    gulp.watch('./wwwroot/sass/*.scss', ['compile-sass']);
    gulp.watch('./wwwroot/sass/**/*.scss', ['compile-sass']);
});
