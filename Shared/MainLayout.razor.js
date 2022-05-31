// To resolve theme selection touch issue on mobile and tablet.
export function preventPopupPropagation() {
  const menuButton = document.querySelector(".mud-menu .mud-button-root");
  if (!menuButton) return;
  menuButton.addEventListener("touchend", function () {
    document
      .querySelector(".mud-popover-provider .mud-popover")
      .removeEventListener("touchend", propupPrevent);
    document
      .querySelector(".mud-popover-provider .mud-popover")
      .addEventListener("touchend", propupPrevent);
  });
}

function propupPrevent(e) {
  e.preventDefault();
}

export function refreshPageHeight(needTimeout) {
  setTimeout(
    function () {
      const page = document.querySelector(".page");
      if (page) {
        page.style.height = page.scrollHeight > page.clientHeight ? "auto" : "";
      }
    },
    needTimeout ? 1000 : 0
  );
}
