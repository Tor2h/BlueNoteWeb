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
badd +16 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/books/books.component.ts
badd +4 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/genres/genres.component.html
badd +14 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/genres/genres.component.ts
badd +24 ~/programming/BlueNoteWeb/webApp/angularapp/package.json
badd +27 ~/programming/BlueNoteWeb/webApp/angularapp/angular.json
badd +52 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/app.module.ts
badd +5627 ~/programming/BlueNoteWeb/webApp/angularapp/package-lock.json
badd +6 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/app.component.html
badd +10 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/app.component.ts
badd +11 ~/programming/BlueNoteWeb/webApp/angularapp/src/index.html
badd +6 ~/programming/BlueNoteWeb/webApp/angularapp/src/main.ts
badd +18 ~/programming/BlueNoteWeb/webApp/angularapp/src/styles.css
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/proxy.conf.js
badd +22 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/books/books.component.html
badd +98 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/create-book/create-book.component.html
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/create-book/create-book.component.css
badd +11 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/genres/create-genre-dialog/create-genre-dialog.component.html
badd +18 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/tropes/tropes.component.html
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/app.component.css
badd +8 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/books/books.component.css
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/create-book/create-book.component.ts
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/genres/create-genre-dialog/create-genre-dialog.component.css
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/genres/create-genre-dialog/create-genre-dialog.component.ts
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/genres/genres.component.css
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/shared/models/Book.ts
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/shared/models/Genre.ts
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/shared/models/Trope.ts
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/shared/services/books.service.ts
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/shared/services/genres.service.ts
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/shared/services/tropes.service.ts
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/tropes/create-trope-dialog/create-trope-dialog.component.css
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/tropes/create-trope-dialog/create-trope-dialog.component.html
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/tropes/create-trope-dialog/create-trope-dialog.component.ts
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/tropes/tropes.component.css
badd +1 ~/programming/BlueNoteWeb/webApp/angularapp/src/app/tropes/tropes.component.ts
badd +4 C:/Notes/BlueNoteWeb/note.md
badd +1 health://
argglobal
%argdel
edit ~/programming/BlueNoteWeb/webApp/angularapp/src/app/books/books.component.ts
argglobal
balt ~/programming/BlueNoteWeb/webApp/angularapp/src/app/books/books.component.html
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
let s:l = 16 - ((15 * winheight(0) + 24) / 49)
if s:l < 1 | let s:l = 1 | endif
keepjumps exe s:l
normal! zt
keepjumps 16
normal! 015|
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
