export function Get(Key) {
    return  localStorage.getItem(Key);
}
export function Set(Key, Value) {
    localStorage.setItem(Key, Value);
}