export class PaginacaoModel {
    pagina: number;
    tamanhoPagina: number;
    termo: string;

    constructor(pagina: number, tamanhoPagina: number) {
        this.pagina = pagina;
        this.tamanhoPagina = tamanhoPagina;
    }
}