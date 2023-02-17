class GDPR {

    constructor() {
        
        this.bindEvents();
        if (this.cookieStatus() == 'accept' || this.cookieStatus() == 'reject') {
            this.hideGDPR();
        } else {
            this.showGDPR
        }

    }

    bindEvents() {
        let buttonAccept = document.querySelector('.button-accept');
        buttonAccept.addEventListener('click', () => {
            console.log("accept click");
            this.cookieStatus('accept');
            this.hideGDPR();
        });


        //student uitwerking
        let buttonReject = document.querySelector('.button-reject');
        buttonReject.addEventListener('click', () => {
            console.log("reject click");
            this.cookieStatus('reject');
            this.hideGDPR();
        });
    }

    

    cookieStatus(status) {
        console.log(status);
        if (status == 'accept') {

            localStorage.setItem('gdpr-consent-choice', status);
        } else {
            if (status == 'reject') localStorage.setItem('gdpr-consent-choice', status);
        }

        //student uitwerking

        return localStorage.getItem('gdpr-consent-choice');
    }

    hideGDPR() {
        document.querySelector(`.cookies`).classList.add('hide');
        document.querySelector(`.cookies`).classList.remove('show');
    }
        
    showGDPR() {
        document.querySelector(`.cookies`).classList.add('show');
    }   
}
const gdpr = new GDPR();


