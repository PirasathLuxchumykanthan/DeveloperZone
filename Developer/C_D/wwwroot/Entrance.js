export function TryToGetKey() {
    alert("halolo world");
    return null;
}

export function SaveHeaderKey(key, Security, Storage) {
    if (!(typeof (Storage) !== "undefined")) {

        return;
    }

    if (Storage == 0) {
        sessionStorage.setItem("Unit.Key", key);
        sessionStorage.setItem("Unit.Key.Security", Security);
    } else {
        localStorage.setItem("Unit.Key", key)
        localStorage.setItem("Unit.Key.Security", Security);
    }

}