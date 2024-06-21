<!-- markdownlint-disable-file MD041 -->
* All [redirection URLs][1] and all URLs embedded in web panels are secure: run Qualys SSL Labs - [SSL Server tests][2] and aim for an A
* SSL 2.0 and 3.0 are disabled
* TLS 1.2 is supported
* All data is [validated on input][3] and escaped on output
* The application uses [federated authentication][4] and [validates all tokens][5] received from SuperOffice

<!-- Referenced links -->
[1]: ../create-app/config/redirects.md
[2]: https://www.ssllabs.com/ssltest/analyze.html
[3]: https://owasp.org/www-project-cheat-sheets/cheatsheets/Input_Validation_Cheat_Sheet
[4]: ../../identity-management/federated-auth.md
[5]: ../../api/authentication/online/validate-security-tokens.md
