let SessionLoad = 1
let s:so_save = &g:so | let s:siso_save = &g:siso | setg so=0 siso=0 | setl so=-1 siso=-1
let v:this_session=expand("<sfile>:p")
silent only
silent tabonly
cd ~/programming/BlueNoteWeb/webApp/angularapp
if expand('%') == '' && !&modified && line('$') <= 1 && getline(1) == ''
  let s:wipebuf = bufnr('%')
endif
let s:shortmess_save = &shortmess
if &shortmess =~ 'A'
  set shortmess=aoOA
else
  set shortmess=aoO
endif
badd +7 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/books/books.component.ts
badd +4 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/genres/genres.component.html
badd +14 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/genres/genres.component.ts
badd +24 ~/programming/BlueNoteWeb/webApp/angularapp/package.json
badd +27 ~/programming/BlueNoteWeb/webApp/angularapp/angular.json
badd +57 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/app.module.ts
badd +5627 ~/programming/BlueNoteWeb/webApp/angularapp/package-lock.json
badd +5 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/app.component.html
badd +10 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/app.component.ts
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/index.html
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/main.ts
badd +18 ~/programming/BlueNoteWeb/webApp/angularapp/src/styles.css
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/proxy.conf.js
argglobal
%argdel
edit ~/programming/BlueNoteWeb/webApp/angularapp/src/index.html
argglobal
balt ~/programming/BlueNoteWeb/webApp/angularapp/src/main.ts
setlocal foldmethod=manual
setlocal foldexpr=0
setlocal foldmarker={{{,}}}
setlocal foldignore=#
setlocal foldlevel=0
setlocal foldminlines=1
setlocal foldnestmax=20
setlocal foldenable
silent! normal! zE
let &fdl = &fdl
let s:l = 15 - ((14 * winheight(0) + 23) / 47)
if s:l < 1 | let s:l = 1 | endif
keepjumps exe s:l
normal! zt
keepjumps 15
normal! 014|
tabnext 1
if exists('s:wipebuf') && len(win_findbuf(s:wipebuf)) == 0 && getbufvar(s:wipebuf, '&buftype') isnot# 'terminal'
  silent exe 'bwipe ' . s:wipebuf
endif
unlet! s:wipebuf
set winheight=1 winwidth=20
let &shortmess = s:shortmess_save
let s:sx = expand("<sfile>:p:r")."x.vim"
if filereadable(s:sx)
  exe "source " . fnameescape(s:sx)
endif
let &g:so = s:so_save | let &g:siso = s:siso_save
set hlsearch
nohlsearch
doautoall SessionLoadPost
unlet SessionLoad
" vim: set ft=vim :
