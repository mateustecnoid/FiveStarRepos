import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { AlertService } from '../services/alert.service';

@Injectable()
export class ErroInterceptor implements HttpInterceptor {

    constructor(private alertService: AlertService) {
    }

    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        return next.handle(req)
            .pipe(catchError(erro => {

                if (erro.status === 400) {
                    let mensagems = erro.error.falhas;

                    mensagems.forEach(mensagem => {
                        this.alertService.aviso(mensagem);
                    });

                    return
                }
                return throwError("Erro ao executar requisição");
            }))
    }

}