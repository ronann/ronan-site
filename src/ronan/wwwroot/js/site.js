// Navbar: transparent over hero, solid when scrolled
const navbar = document.getElementById('navbar');
window.addEventListener('scroll', () => {
    navbar.classList.toggle('scrolled', window.scrollY > 60);
});

// Mobile nav toggle
const navToggle = document.getElementById('navToggle');
const navLinks  = document.getElementById('navLinks');

navToggle?.addEventListener('click', () => {
    navLinks.classList.toggle('open');
});

navLinks?.querySelectorAll('a').forEach(link => {
    link.addEventListener('click', () => navLinks.classList.remove('open'));
});

// Animate skill bars when they scroll into view
const skillFills = document.querySelectorAll('.skill-fill');
if (skillFills.length) {
    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                const fill = entry.target;
                fill.style.width = fill.dataset.width + '%';
                observer.unobserve(fill);
            }
        });
    }, { threshold: 0.2 });

    skillFills.forEach(fill => observer.observe(fill));
}

// Hero scroll indicator — click to scroll to About
document.querySelector('.hero-scroll')?.addEventListener('click', () => {
    document.getElementById('about')?.scrollIntoView({ behavior: 'smooth' });
});
