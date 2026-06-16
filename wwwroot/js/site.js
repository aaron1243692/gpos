// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

document.addEventListener("DOMContentLoaded", () => {
  const ribbon = document.querySelector("[data-gpos-ribbon]");
  const userDropdown = document.getElementById("gposUserDropdown");

  if (userDropdown) {
    document.addEventListener("click", (event) => {
      if (!userDropdown.contains(event.target)) {
        userDropdown.removeAttribute("open");
      }
    });

    document.addEventListener("keydown", (event) => {
      if (event.key === "Escape" && userDropdown.hasAttribute("open")) {
        userDropdown.removeAttribute("open");
        userDropdown.querySelector("summary")?.focus();
      }
    });
  }

  if (!ribbon) {
    return;
  }

  const enableWheelScroll = (element) => {
    if (!element) {
      return;
    }

    element.addEventListener("wheel", (event) => {
      if (element.scrollWidth <= element.clientWidth) {
        return;
      }

      const delta = Math.abs(event.deltaY) > Math.abs(event.deltaX)
        ? event.deltaY
        : event.deltaX;

      if (!delta) {
        return;
      }

      event.preventDefault();
      element.scrollLeft += delta;
    }, { passive: false });
  };

  enableWheelScroll(ribbon.querySelector(".eg-rb-tabs"));
  enableWheelScroll(ribbon.querySelector(".eg-rb-ribbon"));
});
