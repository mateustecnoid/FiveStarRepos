export class PaginacaoModel {
    pagina: number;
    tamanhoPagina: number;

    constructor(pagina: number, tamanhoPagina: number) {
        this.pagina = pagina;
        this.tamanhoPagina = tamanhoPagina;
    }
}